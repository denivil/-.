using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeTextBoxValue(15);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeTextBoxValue(10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeTextBoxValue(3);
        }

        private void ChangeTextBoxValue(int procentValue)
        {
            var textValue = double.Parse(textBox1.Text);

            Procent procent = new Procent(textValue, procentValue);

            textBox1.Text = procent.CountSumTrunc().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab2 lab2 = new Lab2();

            lab2.Show();
        }
    }
}
