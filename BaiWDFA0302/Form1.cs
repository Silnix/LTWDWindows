using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiWDFA0302
{
    public partial class CalculatorForm : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonEquals.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(textBox_Result.Text);
                isOperationPerformed = true;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            result = 0;
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (result + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (result - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (result * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (result / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBox_Result.Text);
            operation = "";
        }

        private void button_Sqrt_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = Math.Sqrt(Double.Parse(textBox_Result.Text)).ToString();
        }

        private void button_MR_Click(object sender, EventArgs e)
        {
            // Implement memory recall functionality here
        }

        private void button_MPlus_Click(object sender, EventArgs e)
        {
            // Implement memory plus functionality here
        }

        private void button_PosNeg_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = (Double.Parse(textBox_Result.Text) * -1).ToString();
        }
    }
}