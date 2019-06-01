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
        public Form3()
        {
            InitializeComponent();
            this.labeNumberGuessed.Visible = false;
            this.labelTrySmallerNumber.Visible = false;
            this.labeNumberGuessed.Visible = false;
            // uz klassi
        }
        private void ButtonGuess_Click(object sender, EventArgs e)
        {
            double inputNumber = double.Parse(textBoxInput.Text);
        }
    }
}
