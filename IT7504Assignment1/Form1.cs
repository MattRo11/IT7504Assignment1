using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT7504Assignment1
{

    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "1";
            calcDisplay.Text += userInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "2";
            calcDisplay.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "3";
            calcDisplay.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "4";
            calcDisplay.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "5";
            calcDisplay.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "6";
            calcDisplay.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "7";
            calcDisplay.Text += userInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "8";
            calcDisplay.Text += userInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "9";
            calcDisplay.Text += userInput;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calcDisplay.Text = "0";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            function = 'x';
            first = userInput;
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                calcDisplay.Text = result.ToString();
            }

            //minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                calcDisplay.Text = result.ToString();
            }

            //divide
            else if (function == '/')
            {
                if(secondNum == '0')
                {
                    calcDisplay.Text = "N/A";
                }
                else
                {
                    result = firstNum / secondNum;
                    calcDisplay.Text = result.ToString();
                }
            }

            //multiply
            else if (function == 'x')
            {
                result = firstNum * secondNum;
                calcDisplay.Text = result.ToString();
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            calcDisplay.Text += ".";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "0";
            calcDisplay.Text += userInput;
        }
    }
}
