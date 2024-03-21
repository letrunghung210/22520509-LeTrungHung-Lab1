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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        List<string>lstfoodlist=new List<string>();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == null)
            {
                return;
            }
            else
            { 
            textBox2.AppendText(text + Environment.NewLine);
            lstfoodlist.Add(text);
            }
            textBox1.Text = string.Empty;
        }
        


    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lstfoodlist.Count == 0)
            {
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(lstfoodlist.Count);

            textBox3.Text = lstfoodlist[randomIndex];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
