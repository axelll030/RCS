namespace PD4
{
    partial class Form2
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
            this.labelEUR = new System.Windows.Forms.Label();
            this.labelUSD = new System.Windows.Forms.Label();
            this.textBoxEUR = new System.Windows.Forms.TextBox();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.buttonToUSD = new System.Windows.Forms.Button();
            this.buttonToEUR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEUR
            // 
            this.labelEUR.AutoSize = true;
            this.labelEUR.Location = new System.Drawing.Point(13, 13);
            this.labelEUR.Name = "labelEUR";
            this.labelEUR.Size = new System.Drawing.Size(33, 13);
            this.labelEUR.TabIndex = 0;
            this.labelEUR.Text = "EUR:";
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(13, 55);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(33, 13);
            this.labelUSD.TabIndex = 1;
            this.labelUSD.Text = "USD:";
            // 
            // textBoxEUR
            // 
            this.textBoxEUR.Location = new System.Drawing.Point(53, 13);
            this.textBoxEUR.Name = "textBoxEUR";
            this.textBoxEUR.Size = new System.Drawing.Size(100, 20);
            this.textBoxEUR.TabIndex = 2;
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Location = new System.Drawing.Point(53, 55);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(100, 20);
            this.textBoxUSD.TabIndex = 3;
            // 
            // buttonToUSD
            // 
            this.buttonToUSD.Location = new System.Drawing.Point(160, 13);
            this.buttonToUSD.Name = "buttonToUSD";
            this.buttonToUSD.Size = new System.Drawing.Size(75, 23);
            this.buttonToUSD.TabIndex = 4;
            this.buttonToUSD.Text = "Uz USD";
            this.buttonToUSD.UseVisualStyleBackColor = true;
            this.buttonToUSD.Click += new System.EventHandler(this.ButtonToUSD_Click);
            // 
            // buttonToEUR
            // 
            this.buttonToEUR.Location = new System.Drawing.Point(160, 51);
            this.buttonToEUR.Name = "buttonToEUR";
            this.buttonToEUR.Size = new System.Drawing.Size(75, 23);
            this.buttonToEUR.TabIndex = 5;
            this.buttonToEUR.Text = "Uz EUR";
            this.buttonToEUR.UseVisualStyleBackColor = true;
            this.buttonToEUR.Click += new System.EventHandler(this.ButtonToEUR_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 99);
            this.Controls.Add(this.buttonToEUR);
            this.Controls.Add(this.buttonToUSD);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.textBoxEUR);
            this.Controls.Add(this.labelUSD);
            this.Controls.Add(this.labelEUR);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEUR;
        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.TextBox textBoxEUR;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.Button buttonToUSD;
        private System.Windows.Forms.Button buttonToEUR;
    }
}