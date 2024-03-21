using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox3.Text, out txt);
            if (isnumber == false && textBox3.Text != "" && textBox3.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập lại ", "Warning!");
                textBox3.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox1.Text, out txt);
            if (isnumber == false && textBox1.Text != "" && textBox1.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập lại ", "Warning!");
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox2.Text, out txt);
            if (isnumber == false && textBox2.Text != "" && textBox2.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập lại ", "Warning!");
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, max = 0, min = 0;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            max = FindMax(a, b, c);
            min = FindMin(a, b, c);
            textBox4.Text = Convert.ToString(max);
            textBox5.Text = Convert.ToString(min);
        }

        private int FindMax(int gt1, int gt2, int gt3)
        {
            int max = gt1;
            if (max < gt2)
            {
                max = gt2;
            }
            if (max < gt3)
            {
                max = gt3;
            }
            return max;
        }

        private int FindMin(int gt1, int gt2, int gt3)
        {
            int min = gt1;
            if (min > gt2)
            {
                min = gt2;
            }
            if (min > gt3)
            {
                min = gt3;
            }
            return min;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
