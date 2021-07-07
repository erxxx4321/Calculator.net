using DynamicExpresso;
using System;
using System.Windows.Forms;

namespace Calculator.net
{
    public partial class Calculator : Form
    {
        string input = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            input += "1";

            textBox1.Text = input;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            input += "2";
         
            textBox1.Text = input;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            input += "3";

            textBox1.Text = input;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            input += "4";
     
            textBox1.Text = input;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            input += "5";

            textBox1.Text = input;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            input += "6";

            textBox1.Text = input;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            input += "7";

            textBox1.Text = input;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            input += "8";

            textBox1.Text = input;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            input += "9";

            textBox1.Text = input;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
           input += "0";

           textBox1.Text = input;
        }

        private void buttonC_Click_1(object sender, EventArgs e)
        {
            input = "";

            textBox1.Text = input;
        }

        private void buttonMult_Click_1(object sender, EventArgs e)
        {
            input += "*";
            oper = "*";

            textBox1.Text = input;
        }

        private void buttonDiv_Click_1(object sender, EventArgs e)
        {
            input += "/";
            oper = "/";

            textBox1.Text = input;
        }

        private void buttonFloa_Click_1(object sender, EventArgs e)
        {
            input += ".";

            textBox1.Text = input;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            input += "+";

            textBox1.Text = input;
        }

        private void buttonSub_Click_1(object sender, EventArgs e)
        { 
            input += "-";

            textBox1.Text = input;
        }

        private void buttonEqu_Click_1(object sender, EventArgs e)
        {
            var interpreter = new Interpreter();
            object result = interpreter.Eval(input);
            textBox1.Text = result.ToString();
        }
    }
}
