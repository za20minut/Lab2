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
    public partial class Form3: Form
    {
        
        public Form3()
        {
            InitializeComponent();

            textBox1.Text = GlobalVars.tester2;
            textBox2.Text = GlobalVars.tester1;
            int liczba1 = int.Parse(textBox1.Text);
            int liczba2 = int.Parse(textBox2.Text);
            textBox3.Text = (liczba1 + liczba2).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
