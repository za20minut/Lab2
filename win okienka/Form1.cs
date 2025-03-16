using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace win_okienka
{
    public partial class Form1: Form
    {
        string currentInput = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            Label label = (Label)sender;
            currentInput = "";
            textBox1.Text = currentInput;
            currentInput += "200";
            textBox1.Text = currentInput;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            currentInput = "";
            textBox1.Text = currentInput;
            currentInput += "300";
            textBox1.Text = currentInput;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            currentInput = "";
            textBox1.Text = currentInput;
            currentInput += "400";
            textBox1.Text = currentInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalVars.tester1 = textBox1.Text;
            Form form3 = new Form3();
            form3.Show();
            this.Hide();

        }

       
    }
}
