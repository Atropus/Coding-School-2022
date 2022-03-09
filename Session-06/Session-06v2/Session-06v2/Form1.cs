using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Session_06v2
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private void SaveValueAndOperatorType(int operation)
        {

            operatorType = operation;
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }
        public Form1()
        {
            InitializeComponent();
        }
        private double firstNum = 0;
        private double secondNum = 0;
        private double result = 0;
        private int operatorType = (int)MathOperations.NoOperator;

        public enum MathOperations
        {

            NoOperator = 0,
            add = 1,
            Minus = 2,
            Divide = 3,
            Multiply = 4,
            Percentage = 5,
            Sqrt = 6,
            Power = 7


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button24_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('-'))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text.Trim('-');

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Percentage);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Sqrt);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstNum = 0;
            secondNum = 0;
            result = 0;
            operatorType = (int)MathOperations.NoOperator;
        }

        private void btnClick(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                if (textBox1.Text == "0")
                {

                    textBox1.Clear();

                }

                textBox1.Text = textBox1.Text + btn.Text;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('.'))
            {
                textBox1.Text += ".";

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(textBox1.Text);
            switch (operatorType)
            {
                case 1:
                    result = firstNum + secondNum;
                    break;
                case 2:
                    result = firstNum - secondNum;
                    break;
                case 3:
                    result = firstNum / secondNum;
                    break;
                case 4:
                    result = firstNum * secondNum;
                    break;
                case 5:
                    result = (firstNum / secondNum) * 100;
                    break;
                case 6:
                    result = Math.Sqrt(firstNum);
                    break;
                case 7:
                    result = Math.Pow(firstNum, secondNum);
                    break;
            }
            textBox1.Text = result.ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Divide);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Sqrt);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Multiply);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Minus);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.add);
        }
    }
}
