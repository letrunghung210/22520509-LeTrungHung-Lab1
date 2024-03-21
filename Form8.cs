using System;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox2.Text);
            int B = int.Parse(textBox1.Text);
            if (comboBox1.SelectedIndex == 1)   // bang cuu chuong
            {
                int k = B - A;
                textBox3.Text = "Bảng cửu chương : B - A = " + k + "\r\n";
                for (int i = 1; i <= 10; i++)
                {
                    textBox3.Text += k + " x " + i + " = ";
                    textBox3.Text += (B * i - A * i).ToString() + "\r\n";
                }
            }
            else if (comboBox1.SelectedIndex == 0)    // tinh toan cac gia tri
            {
                if (A < B)
                {
                    MessageBox.Show("Không tính được (A-B)! vì A-B < 0");

                    textBox3.Text += "S = A^1 + A^2 + A^3 + A^4 + ... + A^B = ";
                    double S = 0;
                    for (int i = 1; i <= B; i++)
                    {
                        S += Math.Pow(A, i);
                    }
                    textBox3.Text += S.ToString();
                }
                else
                {
                    textBox3.Text = "(A - B)! = ";
                    textBox3.Text += Factorial(A - B).ToString() + "\r\n";

                    textBox3.Text += "S = A^1 + A^2 + A^3 + A^4 + ... + A^B = ";
                    double S = 0;
                    for (int i = 1; i <= B; i++)
                    {
                        S += Math.Pow(A, i);
                    }
                    textBox3.Text += S.ToString();
                }

            }

        }
        private int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.Text = string.Empty;

        }
    }
}
