using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_2_operand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txt_op1.Text);
            num2 = Convert.ToDouble(txt_op2.Text);
            result = num1 + num2;
            txt_res.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txt_op1.Text);
            num2 = Convert.ToDouble(txt_op2.Text);
            result = num1 - num2;
            txt_res.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, result=0;
            num1 = Convert.ToDouble(txt_op1.Text);
            num2 = Convert.ToDouble(txt_op2.Text);
            result = num1 * num2;
            txt_res.Text = Convert.ToString(result);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txt_op1.Text);
            num2 = Convert.ToDouble(txt_op2.Text);
            result = num1 / num2;
            txt_res.Text = Convert.ToString(result);


        }
    }
}
