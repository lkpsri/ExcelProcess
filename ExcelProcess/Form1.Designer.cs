namespace ExcelProcess
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpentextBox = new System.Windows.Forms.TextBox();
            this.Openbutton = new System.Windows.Forms.Button();
            this.SavetextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.HFilecheckBox = new System.Windows.Forms.CheckBox();
            this.Excutebutton = new System.Windows.Forms.Button();
            this.OutPuttextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "要打开的Excel路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "要保存的文件路径：";
            // 
            // OpentextBox
            // 
            this.OpentextBox.Location = new System.Drawing.Point(167, 50);
            this.OpentextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpentextBox.Name = "OpentextBox";
            this.OpentextBox.Size = new System.Drawing.Size(260, 25);
            this.OpentextBox.TabIndex = 2;
            // 
            // Openbutton
            // 
            this.Openbutton.Location = new System.Drawing.Point(436, 48);
            this.Openbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Openbutton.Name = "Openbutton";
            this.Openbutton.Size = new System.Drawing.Size(100, 29);
            this.Openbutton.TabIndex = 3;
            this.Openbutton.Text = "打开";
            this.Openbutton.UseVisualStyleBackColor = true;
            this.Openbutton.Click += new System.EventHandler(this.OpenClicked);
            // 
            // SavetextBox
            // 
            this.SavetextBox.Location = new System.Drawing.Point(167, 90);
            this.SavetextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SavetextBox.Name = "SavetextBox";
            this.SavetextBox.Size = new System.Drawing.Size(260, 25);
            this.SavetextBox.TabIndex = 4;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(436, 88);
            this.Savebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(100, 29);
            this.Savebutton.TabIndex = 5;
            this.Savebutton.Text = "另存为";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.SaveClicked);
            // 
            // HFilecheckBox
            // 
            this.HFilecheckBox.AutoSize = true;
            this.HFilecheckBox.Location = new System.Drawing.Point(167, 142);
            this.HFilecheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HFilecheckBox.Name = "HFilecheckBox";
            this.HFilecheckBox.Size = new System.Drawing.Size(74, 19);
            this.HFilecheckBox.TabIndex = 6;
            this.HFilecheckBox.Text = "头文件";
            this.HFilecheckBox.UseVisualStyleBackColor = true;
            this.HFilecheckBox.Click += new System.EventHandler(this.HFileClicked);
            // 
            // Excutebutton
            // 
            this.Excutebutton.Location = new System.Drawing.Point(167, 316);
            this.Excutebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Excutebutton.Name = "Excutebutton";
            this.Excutebutton.Size = new System.Drawing.Size(100, 29);
            this.Excutebutton.TabIndex = 7;
            this.Excutebutton.Text = "生成";
            this.Excutebutton.UseVisualStyleBackColor = true;
            this.Excutebutton.Click += new System.EventHandler(this.ExcuteClicked);
            // 
            // OutPuttextBox
            // 
            this.OutPuttextBox.Location = new System.Drawing.Point(167, 170);
            this.OutPuttextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutPuttextBox.Multiline = true;
            this.OutPuttextBox.Name = "OutPuttextBox";
            this.OutPuttextBox.ReadOnly = true;
            this.OutPuttextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutPuttextBox.Size = new System.Drawing.Size(268, 138);
            this.OutPuttextBox.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "输出信息：";
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(336, 316);
            this.Closebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(100, 29);
            this.Closebutton.TabIndex = 10;
            this.Closebutton.Text = "关闭窗口";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.CloseClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 358);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutPuttextBox);
            this.Controls.Add(this.Excutebutton);
            this.Controls.Add(this.HFilecheckBox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.SavetextBox);
            this.Controls.Add(this.Openbutton);
            this.Controls.Add(this.OpentextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel处理FOR HMI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OpentextBox;
        private System.Windows.Forms.Button Openbutton;
        private System.Windows.Forms.TextBox SavetextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.CheckBox HFilecheckBox;
        private System.Windows.Forms.Button Excutebutton;
        private System.Windows.Forms.TextBox OutPuttextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Closebutton;
    }
}

