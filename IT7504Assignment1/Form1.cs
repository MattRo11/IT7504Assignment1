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
            calcDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "9";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            function = 'c';
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            function = '*';
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            function = '=';
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += ".";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "0";
        }
    }
}
