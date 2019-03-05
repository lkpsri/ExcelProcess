using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ExcelProcess
{
    public partial class MainForm : Form
    {
        private int count = 0;//行计数
        private int Hfile_checked = 0;//选择了头文件
        private int choserow1 = 0;   //默认选择表格0,1列
        private int choserow2 = 1;
        public OleDbConnection Excelconnect = new OleDbConnection();
        //窗体初始化
        public MainForm()
        {
            InitializeComponent();
        }
        //打开按钮按下
        private void OpenClicked(object sender, EventArgs e)
        {
            try//异常处理
            {
                openFileDialog.Filter = "表格文件(*xls;*xlsx)|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OpentextBox.Text = openFileDialog.FileName;
                    OutPuttextBox.AppendText("打开文件已选择！\r\n");
                    //把Excel作为数据库打开，链接后可以读取内容，HDR=NO：把表头也当做内容读取，HDR=YES：第一行作为表头，不能是合并行
                    string ConnetStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + OpentextBox.Text + ";" + "Extended Properties='Excel 12.0;HDR=NO;IMEX=1'";
                    Excelconnect.ConnectionString = ConnetStr;
                    Excelconnect.Open();
                    if (Excelconnect.State == ConnectionState.Open)
                    {
                        DataTable dtSheetName = Excelconnect.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
                        for (int k = 0; k < dtSheetName.Rows.Count; k++)
                        {   //循环查找名字并且过滤掉其他名字结尾的，只取$结尾的
                            if (dtSheetName.Rows[k]["TABLE_NAME"].ToString().EndsWith("$"))
                            { InterfaceData.SheetList.Add(dtSheetName.Rows[k]["TABLE_NAME"].ToString()); }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //保存按钮按下
        private void SaveClicked(object sender, EventArgs e)
        {
            try//异常处理
            {
                saveFileDialog.Filter = "所有文件(*.*)|*.*";
                saveFileDialog.FileName = "allfailure.h";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SavetextBox.Text = saveFileDialog.FileName;
                    OutPuttextBox.AppendText("保存路径已选择！\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //选择头文件
        private void HFileClicked(object sender, EventArgs e)
        {
            if (HFilecheckBox.CheckState == CheckState.Checked)
            {
                Hfile_checked = 1;
                OutPuttextBox.AppendText("已选择生成头文件！\r\n");
                SelectRowForm form2 = new SelectRowForm();
                form2.ShowDialog(this);
                if (form2.DialogResult == DialogResult.OK)
                {
                    choserow1 = form2.ROW1;
                    choserow2 = form2.ROW2;
                    OutPuttextBox.AppendText("已选择列，序号：" + choserow1 + "   序号：" + choserow2 + "！\r\n");
                }
                else 
                {
                    OutPuttextBox.AppendText("没有选择列，默认第1列和第2列！\r\n");
                }
            }
            else 
            {
                Hfile_checked = 0;
                OutPuttextBox.AppendText("需要重新选择生成类型！\r\n");
            }
        }
        //执行按钮按下
        private void ExcuteClicked(object sender, EventArgs e)
        {
            if (OpentextBox.Text == string.Empty)
            {
                MessageBox.Show("打开文件路径不能为空！");
            }
            else if (SavetextBox.Text == string.Empty)
            {
                MessageBox.Show("保存文件路径不能为空！");
            }
            else if (Hfile_checked == 0)
            {
                MessageBox.Show("生成文件类型未选择！");
            }
            else 
            {
                try
                {
                    if (Excelconnect.State == ConnectionState.Open)
                    {
                        SheetChose sheetchoseForm = new SheetChose();
                        sheetchoseForm.ShowDialog(this);
                        if (sheetchoseForm.DialogResult == DialogResult.OK)
                        {
                            string strExcel = "SELECT * From [" + sheetchoseForm.SHEETNAME + "] where F1 is not null";//SQL语句选择表1非空内容
                            OleDbDataAdapter ExcelAdp = new OleDbDataAdapter(strExcel, Excelconnect);//数据过滤，只取SHEET1内容
                            DataSet ExcelData = new DataSet();
                            ExcelAdp.Fill(ExcelData, "Fault");//把过滤出的数据填充至DataSet “Fault”表中

                            count = ExcelData.Tables["Fault"].Rows.Count;
                            OutPuttextBox.AppendText("Excel表格行数：" + (count - 1) + "\r\n");

                            StreamWriter write = new StreamWriter(SavetextBox.Text, false);
                            write.Write("#define ALLFAILURE {\\\r\n");
                            write.Write("                /*total," + (count - 1) + "*/\\\r\n");
                            for (int i = 1; i < count; i++)
                            {
                                write.Write("                " + ExcelData.Tables["Fault"].Rows[i][choserow1] + ",        ");
                                write.Write("                /*" + ExcelData.Tables["Fault"].Rows[i][choserow2] + "*/\\\r\n");
                            }
                            write.Write("}");
                            write.Close();
                            Excelconnect.Close();
                            OutPuttextBox.AppendText("生成头文件成功！\r\n");
                            MessageBox.Show("生成头文件成功!");
                        }
                        else
                        {
                            OutPuttextBox.AppendText("请先选择SheetName！\r\n");
                            OutPuttextBox.AppendText("未生成成功！\r\n");
                        }
                            
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    OutPuttextBox.AppendText("未生成成功！\r\n");
                }
            }
        }

        private void CloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
