using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelProcess
{
    public partial class SheetChose : Form
    {
        private string sheetname;
        public string SHEETNAME
        {
            get
            {
                return sheetname;
            }
        }
        public SheetChose()
        {
            InitializeComponent();
            OKbutton.DialogResult = DialogResult.OK;
            Cancelbutton.DialogResult = DialogResult.Cancel;
        }

        private void SheetChose_Load(object sender, EventArgs e)
        {
            foreach (string str in InterfaceData.SheetList)
                Sheet_comboBox.Items.Add(str);
            Sheet_comboBox.SelectedIndex = 0;
        }

        private void Sheet_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sheet_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            sheetname = Sheet_comboBox.Text;
        }
    }
}
