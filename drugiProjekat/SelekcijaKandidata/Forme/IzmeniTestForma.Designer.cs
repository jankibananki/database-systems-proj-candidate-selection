namespace SelekcijaKandidata.Forme
{
    partial class IzmeniTestForma
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
            this.cbCV = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbVrsta = new System.Windows.Forms.TextBox();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.tbKomentar = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.labelCV = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelVrsta = new System.Windows.Forms.Label();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.labelKomentar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCV
            // 
            this.cbCV.FormattingEnabled = true;
            this.cbCV.Location = new System.Drawing.Point(150, 30);
            this.cbCV.Name = "cbCV";
            this.cbCV.Size = new System.Drawing.Size(250, 21);
            this.cbCV.TabIndex = 0;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(150, 70);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(250, 20);
            this.dtpDatum.TabIndex = 1;
            // 
            // tbVrsta
            // 
            this.tbVrsta.Location = new System.Drawing.Point(150, 110);
            this.tbVrsta.Name = "tbVrsta";
            this.tbVrsta.Size = new System.Drawing.Size(250, 20);
            this.tbVrsta.TabIndex = 2;
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(150, 150);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.Size = new System.Drawing.Size(250, 20);
            this.tbRezultat.TabIndex = 3;
            // 
            // tbKomentar
            // 
            this.tbKomentar.Location = new System.Drawing.Point(150, 190);
            this.tbKomentar.Name = "tbKomentar";
            this.tbKomentar.Size = new System.Drawing.Size(250, 20);
            this.tbKomentar.TabIndex = 4;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(35, 240);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(255, 240);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 6;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            this.labelCV.AutoSize = true; this.labelCV.Location = new System.Drawing.Point(35, 33); this.labelCV.Text = "Kandidat";
            this.labelDatum.AutoSize = true; this.labelDatum.Location = new System.Drawing.Point(35, 73); this.labelDatum.Text = "Datum";
            this.labelVrsta.AutoSize = true; this.labelVrsta.Location = new System.Drawing.Point(35, 113); this.labelVrsta.Text = "Vrsta testa";
            this.labelRezultat.AutoSize = true; this.labelRezultat.Location = new System.Drawing.Point(35, 153); this.labelRezultat.Text = "Rezultat";
            this.labelKomentar.AutoSize = true; this.labelKomentar.Location = new System.Drawing.Point(35, 193); this.labelKomentar.Text = "Komentar";
            // 
            // IzmeniTestForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 300);
            this.Controls.Add(this.labelCV); this.Controls.Add(this.labelDatum); this.Controls.Add(this.labelVrsta); this.Controls.Add(this.labelRezultat); this.Controls.Add(this.labelKomentar);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.tbKomentar);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.tbVrsta);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbCV);
            this.Name = "IzmeniTestForma";
            this.Text = "Izmeni test";
            this.Load += new System.EventHandler(this.IzmeniTestForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCV;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbVrsta;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.TextBox tbKomentar;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelVrsta;
        private System.Windows.Forms.Label labelRezultat;
        private System.Windows.Forms.Label labelKomentar;
    }
}