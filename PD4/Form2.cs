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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBoxEUR.Text = "0";
            textBoxUSD.Text = "0";
        }

        private void ButtonToUSD_Click(object sender, EventArgs e)
        {
            double EUR = double.Parse(textBoxEUR.Text);
            double res = EUR * 1.12;
            textBoxUSD.Text = res.ToString();
            textBoxEUR.Text = "0";
        }

        private void ButtonToEUR_Click(object sender, EventArgs e)
        {
            double USD = double.Parse(textBoxUSD.Text);
            double res = USD * 0.89;
            textBoxEUR.Text = res.ToString();
            textBoxUSD.Text = "0";
        }
    }
}
