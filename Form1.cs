using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_result_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int first_Number = int.Parse(textBox1.Text);
            int second_number = int.Parse(textBox2.Text);
            int result = first_Number + second_number;
            textBox3.Text = result.ToString();


        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            int first_Number = int.Parse(textBox1.Text);
            int second_number = int.Parse(textBox2.Text);
            int result = first_Number - second_number;
            textBox3.Text = result.ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            int first_Number = int.Parse(textBox1.Text);
            int second_number = int.Parse(textBox2.Text);
            int result = first_Number / second_number;
            textBox3.Text = result.ToString();

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            int first_Number = int.Parse(textBox1.Text);
            int second_number = int.Parse(textBox2.Text);
            int result = first_Number * second_number;
            textBox3.Text = result.ToString();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
