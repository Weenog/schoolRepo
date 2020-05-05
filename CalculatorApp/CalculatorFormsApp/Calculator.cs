using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {

        Double resultValue = 0;
        String operationSymbol = "";
        bool IsOperationPerformed = false;

        public Form1(){InitializeComponent(); labelCurrentOperation.Text = " "; }
        private void Form1_Load(object sender, EventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}



        private void numberButton_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (IsOperationPerformed))
                textBox_Result.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            
            textBox_Result.Text = textBox_Result.Text + button.Text;
           
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            labelCurrentOperation.Text = " ";
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationSymbol = button.Text;
            resultValue = Convert.ToDouble(textBox_Result.Text);
            labelCurrentOperation.Text = resultValue + " " + operationSymbol;
            IsOperationPerformed = true;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            switch(operationSymbol)
            {
                case "+": textBox_Result.Text= (resultValue + Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;

            }
             if (textBox_Result.Text == "∞") textBox_Result.Text = "Resultaat niet mogelijk.";
             if (textBox_Result.Text == "NaN") textBox_Result.Text = "Resultaat niet mogelijk.";
        }
    }
}
