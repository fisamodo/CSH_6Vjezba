namespace csh6lab
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
            this.pregledKnjiga1 = new csh6lab.PregledKnjiga();
            this.kraj1 = new csh6lab.Kraj();
            this.logIn1 = new csh6lab.LogIn();
            this.greska1 = new csh6lab.Greska();
            this.SuspendLayout();
            // 
            // pregledKnjiga1
            // 
            this.pregledKnjiga1.Location = new System.Drawing.Point(322, 72);
            this.pregledKnjiga1.Name = "pregledKnjiga1";
            this.pregledKnjiga1.Size = new System.Drawing.Size(457, 366);
            this.pregledKnjiga1.TabIndex = 0;
            this.pregledKnjiga1.Visible = false;
            // 
            // kraj1
            // 
            this.kraj1.Location = new System.Drawing.Point(25, 232);
            this.kraj1.Name = "kraj1";
            this.kraj1.Size = new System.Drawing.Size(317, 164);
            this.kraj1.TabIndex = 1;
            this.kraj1.Visible = false;
            // 
            // logIn1
            // 
            this.logIn1.Location = new System.Drawing.Point(12, 12);
            this.logIn1.Name = "logIn1";
            this.logIn1.Size = new System.Drawing.Size(347, 246);
            this.logIn1.TabIndex = 2;
            // 
            // greska1
            // 
            this.greska1.Location = new System.Drawing.Point(448, -5);
            this.greska1.Name = "greska1";
            this.greska1.Size = new System.Drawing.Size(299, 202);
            this.greska1.TabIndex = 3;
            this.greska1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greska1);
            this.Controls.Add(this.logIn1);
            this.Controls.Add(this.kraj1);
            this.Controls.Add(this.pregledKnjiga1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PregledKnjiga pregledKnjiga1;
        private Kraj kraj1;
        private LogIn logIn1;
        private Greska greska1;
    }
}

