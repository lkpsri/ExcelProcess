namespace ExcelProcess
{
    partial class SheetChose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sheet_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sheet_comboBox
            // 
            this.Sheet_comboBox.FormattingEnabled = true;
            this.Sheet_comboBox.Location = new System.Drawing.Point(108, 33);
            this.Sheet_comboBox.Name = "Sheet_comboBox";
            this.Sheet_comboBox.Size = new System.Drawing.Size(100, 20);
            this.Sheet_comboBox.TabIndex = 0;
            this.Sheet_comboBox.SelectedIndexChanged += new System.EventHandler(this.Sheet_comboBox_SelectedIndexChanged);
            this.Sheet_comboBox.SelectedValueChanged += new System.EventHandler(this.Sheet_comboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sheet名称：";
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(47, 82);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(55, 23);
            this.OKbutton.TabIndex = 4;
            this.OKbutton.Text = "确定";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(144, 82);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(55, 23);
            this.Cancelbutton.TabIndex = 6;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // SheetChose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 128);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sheet_comboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SheetChose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请选择Sheet!";
            this.Load += new System.EventHandler(this.SheetChose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Sheet_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}