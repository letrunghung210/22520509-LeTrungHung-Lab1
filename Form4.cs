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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox3.Text, out txt);
            if (isnumber == false && textBox3.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Warning!");
                textBox3.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Int32.Parse(textBox3.Text))
            {
                case 0:
                    textBox1.Text = "Không";
                    break;
                case 1:
                    textBox1.Text = ("Một");
                    break;
                case 2:
                    textBox1.Text = ("Hai");
                    break;
                case 3:
                    textBox1.Text = ("Ba");
                    break;
                case 4:
                    textBox1.Text = ("Bốn");
                    break;
                case 5:
                    textBox1.Text = ("Năm");
                    break;
                case 6:
                    textBox1.Text = ("Sáu");
                    break;
                case 7:
                    textBox1.Text = ("Bảy");
                    break;
                case 8:
                    textBox1.Text = ("Tám");
                    break;
                case 9:
                    textBox1.Text = ("Chín");
                    break;
                default:
                    MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Warning!");
                    textBox3.Text = "";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2 .Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


        

      
    

       

