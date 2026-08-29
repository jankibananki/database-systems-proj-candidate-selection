namespace SelekcijaKandidata
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
            this.btnCV = new System.Windows.Forms.Button();
            this.btnIntervju = new System.Windows.Forms.Button();
            this.btnOdluka = new System.Windows.Forms.Button();
            this.btnOglas = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(241, 52);
            this.btnCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(100, 28);
            this.btnCV.TabIndex = 0;
            this.btnCV.Text = "CV-evi";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnIntervju
            // 
            this.btnIntervju.Location = new System.Drawing.Point(241, 107);
            this.btnIntervju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIntervju.Name = "btnIntervju";
            this.btnIntervju.Size = new System.Drawing.Size(100, 26);
            this.btnIntervju.TabIndex = 1;
            this.btnIntervju.Text = "Intervjui";
            this.btnIntervju.UseVisualStyleBackColor = true;
            this.btnIntervju.Click += new System.EventHandler(this.btnIntervju_Click);
            // 
            // btnOdluka
            // 
            this.btnOdluka.Location = new System.Drawing.Point(241, 160);
            this.btnOdluka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdluka.Name = "btnOdluka";
            this.btnOdluka.Size = new System.Drawing.Size(100, 26);
            this.btnOdluka.TabIndex = 2;
            this.btnOdluka.Text = "Odluke";
            this.btnOdluka.UseVisualStyleBackColor = true;
            this.btnOdluka.Click += new System.EventHandler(this.btnOdluka_Click);
            // 
            // btnOglas
            // 
            this.btnOglas.Location = new System.Drawing.Point(241, 209);
            this.btnOglas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOglas.Name = "btnOglas";
            this.btnOglas.Size = new System.Drawing.Size(100, 26);
            this.btnOglas.TabIndex = 3;
            this.btnOglas.Text = "Oglasi";
            this.btnOglas.UseVisualStyleBackColor = true;
            this.btnOglas.Click += new System.EventHandler(this.btnOglas_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(241, 256);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 26);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Testovi";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(241, 308);
            this.btnZaposleni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(100, 26);
            this.btnZaposleni.TabIndex = 5;
            this.btnZaposleni.Text = "Zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 375);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnOglas);
            this.Controls.Add(this.btnOdluka);
            this.Controls.Add(this.btnIntervju);
            this.Controls.Add(this.btnCV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Selekcija kandidata";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnIntervju;
        private System.Windows.Forms.Button btnOdluka;
        private System.Windows.Forms.Button btnOglas;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnZaposleni;
    }
}

