using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox1.Text, out txt);
            if (isnumber == false && textBox1.Text != "" && textBox1.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox2.Text, out txt);
            if (isnumber == false && textBox2.Text != "" && textBox2.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                textBox2.Text = "";
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text.Trim());
            int b = int.Parse(textBox2.Text.Trim());
            int sum = a + b;
            textBox3.Text = sum.ToString();
        }
    }
}