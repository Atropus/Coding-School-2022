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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "÷";
            this.textBox2.Text += "÷";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "7";
            this.textBox2.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";
            this.textBox2.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "9";
            this.textBox2.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "x";
            this.textBox2.Text += "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "4";
            this.textBox2.Text += "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";
            this.textBox2.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "6";
            this.textBox2.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "-";
            this.textBox2.Text += "-";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "1";
            this.textBox2.Text += "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "2";
            this.textBox2.Text += "2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";
            this.textBox2.Text += "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "+";
            this.textBox2.Text += "+";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += ".";
            this.textBox2.Text += ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //TODO Calculation clear
        }
    }
}
