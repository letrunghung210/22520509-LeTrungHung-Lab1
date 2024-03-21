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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox3.Text, out txt);
            if (isnumber == false && textBox3.Text != "" && textBox3.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                textBox3.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long number = long.Parse(textBox3.Text);
            textBox1.Text = ReadNumber(number);
        }
        private string ReadThreeDigits(int n)
        {
            string[] units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] hundreds = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };

            int unit = n % 10;
            int ten = (n / 10) % 10;
            int hundred = n / 100;

            string result = "";
            if (hundred != 0)
            {
                result += hundreds[hundred] + " ";
            }
            if (ten != 0)
            {
                if (ten == 1 && unit > 0)
                {
                    result += "mười " + units[unit] + " ";
                }
                else
                {
                    result += tens[ten] + " ";
                }
            }
            if (unit != 0 && ten != 1)
            {
                result += units[unit] + " ";
            }

            return result;
        }

        private string ReadNumber(long n)
        {
            string[] suffixes = { "", "ngàn", "triệu", "tỷ" };
            int[] parts = new int[4];

            for (int i = 0; i < 4; i++)
            {
                parts[i] = (int)(n % 1000);
                n /= 1000;
            }

            string result = "";
            for (int i = 3; i >= 0; i--)
            {
                if (parts[i] != 0)
                {
                    result += ReadThreeDigits(parts[i]) + " " + suffixes[i] + " ";
                }
                else if (i > 0 && parts[i - 1] != 0)
                {
                    result += "";
                }
            }

            return result.Trim();
        }
    }
}


