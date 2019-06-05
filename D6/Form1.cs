using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D6
{
    public partial class Form1 : Form
    {
        string enteredNumber = "";
        string operation = "";
        bool isOperationClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            clearClicked();
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {

        }

        void operationClicked(string operation)
        {
            if (enteredNumber == "")
            {
                enteredNumber = textBox1.Text;
            }
            if (enteredNumber != null)
            { }
            /* 1. ja ievaditais skaitlis nav definets:
             * 1.1 sobrid attelotais skaitlis jasaglaba ka ievaditaisSkaitlis
             * 1.2. izveleta darbiba jasaglaba ka operation
             * 2. ja ievaditaisSkaitlis ir definets
             * 2.1 izpilda equalsClicked()*/
        }
        void equalClicked()
        {
           /* 1. parversievaditoskaitli uz int
              2. parvers ievadlauka skaitli u int
              3. aprekina reultatu strap abiem skaitliem izmantojot operation darbibu
              4. atelo rez ievadlauka*/
        }
        void clearClicked()
        {
            isOperationClicked = false;
            string enteredNumber = "";
            string operation = "";
            textBox1.Text = "";
            // 1. notiravisu mainigo vertinu un ievadauka atteloto
        }

        void numberClicked(int number)
        {
            textBox1.Text += number; //ta ka vajag pievienot liekam PLUS VIENADS
            switch (isOperationClicked)
            {
                case true:
                    textBox1.Text = "";
                    break;
                default:
                    break;
                    
            }
            switch (textBox1.Text)
            {
                case "0":
                    textBox1.Text = "";
                    break;
            }
            /* 1. nospiesto ciparu pievienot ievadlaukumam
             * 2. ja pirms cipara tika nospiesta darbiba, tad notira ievadlaukumu
             * 3. ja ievadlaukuma ir cipars 0, tad notira ievadlaukumu*/
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            numberClicked(1);
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            numberClicked(2);
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            numberClicked(3);
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            numberClicked(4);
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            numberClicked(5);
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            numberClicked(6);
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            numberClicked(7);
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            numberClicked(8);
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            numberClicked(9);
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            numberClicked(0);
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            operationClicked("+");
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            operationClicked("-");
        }

        private void ButtoMult_Click(object sender, EventArgs e)
        {
            operationClicked("*");
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            operationClicked("/");
        }
    }
}
