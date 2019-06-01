namespace Formas_Piemeri
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_confirm = new System.Windows.Forms.Button();
            this.lb_vards = new System.Windows.Forms.Label();
            this.textbox_vards = new System.Windows.Forms.TextBox();
            this.lb_info = new System.Windows.Forms.Label();
            this.lb_uzvards = new System.Windows.Forms.Label();
            this.textbox_uzvards = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(145, 137);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(228, 23);
            this.bt_confirm.TabIndex = 0;
            this.bt_confirm.Text = "OK";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.Bt_confirm_Click);
            // 
            // lb_vards
            // 
            this.lb_vards.AutoSize = true;
            this.lb_vards.Location = new System.Drawing.Point(65, 86);
            this.lb_vards.Name = "lb_vards";
            this.lb_vards.Size = new System.Drawing.Size(34, 13);
            this.lb_vards.TabIndex = 1;
            this.lb_vards.Text = "Vārds";
            // 
            // textbox_vards
            // 
            this.textbox_vards.Location = new System.Drawing.Point(161, 86);
            this.textbox_vards.Name = "textbox_vards";
            this.textbox_vards.Size = new System.Drawing.Size(196, 20);
            this.textbox_vards.TabIndex = 2;
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Location = new System.Drawing.Point(242, 185);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(35, 13);
            this.lb_info.TabIndex = 3;
            this.lb_info.Text = "label1";
            // 
            // lb_uzvards
            // 
            this.lb_uzvards.AutoSize = true;
            this.lb_uzvards.Location = new System.Drawing.Point(65, 114);
            this.lb_uzvards.Name = "lb_uzvards";
            this.lb_uzvards.Size = new System.Drawing.Size(46, 13);
            this.lb_uzvards.TabIndex = 4;
            this.lb_uzvards.Text = "Uzvārds";
            // 
            // textbox_uzvards
            // 
            this.textbox_uzvards.Location = new System.Drawing.Point(161, 111);
            this.textbox_uzvards.Name = "textbox_uzvards";
            this.textbox_uzvards.Size = new System.Drawing.Size(196, 20);
            this.textbox_uzvards.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 225);
            this.Controls.Add(this.textbox_uzvards);
            this.Controls.Add(this.lb_uzvards);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.textbox_vards);
            this.Controls.Add(this.lb_vards);
            this.Controls.Add(this.bt_confirm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.Label lb_vards;
        private System.Windows.Forms.TextBox textbox_vards;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Label lb_uzvards;
        private System.Windows.Forms.TextBox textbox_uzvards;
    }
}

