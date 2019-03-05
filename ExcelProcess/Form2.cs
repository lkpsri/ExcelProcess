using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelProcess
{
    public partial class SelectRowForm : Form
    {
        private string row1 = "A";
        private string row2 = "B"; 
        private int temp;
        public int ROW1
        {
            get 
            {
                switch (row1)
                {
                    case "A": temp = 0; break;
                    case "B": temp = 1; break;
                    case "C": temp = 2; break;
                    case "D": temp = 3; break;
                    case "E": temp = 4; break;
                    case "F": temp = 5; break;
                    case "G": temp = 6; break;
                    case "H": temp = 7; break;
                    case "I": temp = 8; break;
                }
                return temp;
            }
        }
        public int ROW2
        {
            get
            {
                switch (row2)
                {
                    case "A": temp = 0; break;
                    case "B": temp = 1; break;
                    case "C": temp = 2; break;
                    case "D": temp = 3; break;
                    case "E": temp = 4; break;
                    case "F": temp = 5; break;
                    case "G": temp = 6; break;
                    case "H": temp = 7; break;
                    case "I": temp = 8; break;
                }
                return temp;
            }
        }
        public SelectRowForm()
        {
            InitializeComponent();
            OKbutton.DialogResult = DialogResult.OK;
            Cancelbutton.DialogResult = DialogResult.Cancel;
        }

        private void SelectRow_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
            comboBox1.Items.Add("E");
            comboBox1.Items.Add("F");
            comboBox1.Items.Add("G");
            comboBox1.Items.Add("H");
            comboBox1.Items.Add("I");
            comboBox2.Items.Add("A");
            comboBox2.Items.Add("B");
            comboBox2.Items.Add("C");
            comboBox2.Items.Add("D");
            comboBox2.Items.Add("E");
            comboBox2.Items.Add("F");
            comboBox2.Items.Add("G");
            comboBox2.Items.Add("H");
            comboBox2.Items.Add("I");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void comb1_SelectValueChanged(object sender, EventArgs e)
        {
            row1 = comboBox1.Text;
        }

        private void comb2_SelectValueChanged(object sender, EventArgs e)
        {
            row2 = comboBox2.Text;
        }
    }
}
