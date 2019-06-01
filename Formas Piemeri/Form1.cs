using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formas_Piemeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.lb_info.Visible = false;
        }

        private void Bt_confirm_Click(object sender, EventArgs e)
        {
            lb_info.Visible = true;
            lb_info.Text = String.Format("Tevi sauc {0} {1}!", textbox_vards.Text, textbox_uzvards.Text);
            textbox_vards.Text = "";
            textbox_uzvards.Text = "";
        }
    }
}
