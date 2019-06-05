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
    public partial class Form3 : Form
    {
        int inputNumber;
        int numberToGuess;
        public Form3()
        {
            InitializeComponent();
            ButtonRestart_Click(null, null);    //sak speli no jauna
        }
        private void ButtonGuess_Click(object sender, EventArgs e)
        {
            inputNumber = int.Parse(textBoxInput.Text);
            if (inputNumber < numberToGuess)
            {
                labelWonLost.Text = "Parak maz!";
            }
            else if (inputNumber > numberToGuess)
            {
                labelWonLost.Text = "Parak daudz!";
            }
            else
            {
                labelWonLost.Text = "Jus minejat skaitli!";
            }
            this.labelWonLost.Visible = true;
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            numberToGuess = new Random().Next(1, 101);
            textBoxInput.Text = "";
            this.labelWonLost.Visible = false;
        }
    }
}
