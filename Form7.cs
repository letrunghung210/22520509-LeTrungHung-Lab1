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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int day = int.Parse(textBox1.Text);
            int month = int.Parse(textBox2.Text);

            
            string zodiacSign = DetermineZodiacSign(day, month);

            
            MessageBox.Show($"Cung hoàng đạo của bạn là: {zodiacSign}", "Thông tin cung hoàng đạo");
        }
        private string DetermineZodiacSign(int day, int month)
        {
            if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
                return "Bạch Dương";
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
                return "Kim Ngưu";
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
                return "Song Tử";
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                return "Cự Giải";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Sư Tử";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 23))
                return "Xử Nữ";
            else if ((month == 9 && day >= 24) || (month == 10 && day <= 23))
                return "Thiên Bình";
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
                return "Thần Nông";
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
                return "Nhân Mã";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 20))
                return "Ma Kết";
            else if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
                return "Bảo Bình";
            else
                return "Song Ngư";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
