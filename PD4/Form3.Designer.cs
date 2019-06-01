namespace PD4
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.labelTrySmallerNumber = new System.Windows.Forms.Label();
            this.labeNumberGuessed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uzmini skaitli!";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(164, 13);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(111, 23);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Sākt no jauna";
            this.buttonRestart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tāvs minējums:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(111, 53);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 3;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(233, 49);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(42, 23);
            this.buttonGuess.TabIndex = 4;
            this.buttonGuess.Text = "Minēt";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.ButtonGuess_Click);
            // 
            // labelTrySmallerNumber
            // 
            this.labelTrySmallerNumber.AutoSize = true;
            this.labelTrySmallerNumber.Location = new System.Drawing.Point(79, 107);
            this.labelTrySmallerNumber.Name = "labelTrySmallerNumber";
            this.labelTrySmallerNumber.Size = new System.Drawing.Size(108, 13);
            this.labelTrySmallerNumber.TabIndex = 5;
            this.labelTrySmallerNumber.Text = "Mēģini mazaku skaiti!";
            // 
            // labeNumberGuessed
            // 
            this.labeNumberGuessed.AutoSize = true;
            this.labeNumberGuessed.Location = new System.Drawing.Point(79, 107);
            this.labeNumberGuessed.Name = "labeNumberGuessed";
            this.labeNumberGuessed.Size = new System.Drawing.Size(102, 13);
            this.labeNumberGuessed.TabIndex = 5;
            this.labeNumberGuessed.Text = "Jūs uzminējat skaitli!";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 145);
            this.Controls.Add(this.labeNumberGuessed);
            this.Controls.Add(this.labelTrySmallerNumber);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label labelTrySmallerNumber;
        private System.Windows.Forms.Label labeNumberGuessed;
    }
}