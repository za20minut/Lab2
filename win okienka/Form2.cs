using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_okienka
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Text = "450";
                    break;
                case 1:
                    textBox1.Text = "550";
                    break;
                default:
                    textBox1.Text = "";
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = "150";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Text = "350";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox2.Text = "500";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3("s");
            form3.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int liczba1 = int.Parse(textBox1.Text);
            int liczba2 = int.Parse(textBox2.Text);
            textBox3.Text = (liczba1 + liczba2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string wartosc = textBox3.Text;
            Form form3 = new Form3(wartosc);
            form3.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int liczba1 = int.Parse(textBox1.Text);
            int liczba2 = int.Parse(textBox2.Text);
            label3.Text = (liczba1 + liczba2).ToString();
        }
    }
}
