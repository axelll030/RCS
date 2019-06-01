using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            labelResult.Visible = true;
            double firstNumber = double.Parse(inputFirstNumber.Text);
            double secondNumber = double.Parse(inputSecondNumber.Text);
            double res = firstNumber + secondNumber;
            labelResult.Text = res.ToString();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            labelResult.Visible = true;
            double firstNumber = double.Parse(inputFirstNumber.Text);
            double secondNumber = double.Parse(inputSecondNumber.Text);
            double res = firstNumber - secondNumber;
            labelResult.Text = res.ToString();
        }

        private void ButtonTimes_Click(object sender, EventArgs e)
        {
            labelResult.Visible = true;
            double firstNumber = double.Parse(inputFirstNumber.Text);
            double secondNumber = double.Parse(inputSecondNumber.Text);
            double res = firstNumber * secondNumber;
            labelResult.Text = res.ToString();
        }

        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            labelResult.Visible = true;
            double firstNumber = double.Parse(inputFirstNumber.Text);
            double secondNumber = double.Parse(inputSecondNumber.Text);
            double res = (firstNumber + secondNumber) / 2;
            labelResult.Text = res.ToString();
        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            labelResult.Visible = true;
            double firstNumber = double.Parse(inputFirstNumber.Text);
            double secondNumber = double.Parse(inputSecondNumber.Text);
            double res;
            if (firstNumber > secondNumber )
            {
                res = firstNumber;
            }
            else
                res = secondNumber;

            labelResult.Text = res.ToString();
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            labelResult.Visible = true;
            double firstNumber = double.Parse(inputFirstNumber.Text);
            double secondNumber = double.Parse(inputSecondNumber.Text);
            double res;
            if (firstNumber < secondNumber)
            {
                res = firstNumber;
            }
            else
                res = secondNumber;

            labelResult.Text = res.ToString();
        }
    }
}
