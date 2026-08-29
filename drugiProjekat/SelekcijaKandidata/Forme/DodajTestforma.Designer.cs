namespace SelekcijaKandidata.Forme
{
    partial class DodajTestforma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cbKandidat = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbVrsta = new System.Windows.Forms.TextBox();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.tbKomentar = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.labelCV = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelVrsta = new System.Windows.Forms.Label();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.labelKomentar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbKandidat
            // 
            this.cbKandidat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKandidat.Location = new System.Drawing.Point(150, 30);
            this.cbKandidat.Name = "cbKandidat";
            this.cbKandidat.Size = new System.Drawing.Size(250, 21);
            this.cbKandidat.TabIndex = 5;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(150, 70);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(250, 20);
            this.dtpDatum.TabIndex = 6;
            // 
            // tbVrsta
            // 
            this.tbVrsta.Location = new System.Drawing.Point(150, 110);
            this.tbVrsta.Name = "tbVrsta";
            this.tbVrsta.Size = new System.Drawing.Size(250, 20);
            this.tbVrsta.TabIndex = 7;
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(150, 150);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.Size = new System.Drawing.Size(250, 20);
            this.tbRezultat.TabIndex = 8;
            // 
            // tbKomentar
            // 
            this.tbKomentar.Location = new System.Drawing.Point(150, 190);
            this.tbKomentar.Name = "tbKomentar";
            this.tbKomentar.Size = new System.Drawing.Size(250, 20);
            this.tbKomentar.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(35, 240);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(95, 25);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(145, 240);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(95, 25);
            this.btnOcisti.TabIndex = 11;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(255, 240);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(95, 25);
            this.btnNazad.TabIndex = 12;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.Location = new System.Drawing.Point(35, 33);
            this.labelCV.Name = "labelCV";
            this.labelCV.Size = new System.Drawing.Size(49, 13);
            this.labelCV.TabIndex = 0;
            this.labelCV.Text = "Kandidat";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(35, 73);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(38, 13);
            this.labelDatum.TabIndex = 1;
            this.labelDatum.Text = "Datum";
            // 
            // labelVrsta
            // 
            this.labelVrsta.AutoSize = true;
            this.labelVrsta.Location = new System.Drawing.Point(35, 113);
            this.labelVrsta.Name = "labelVrsta";
            this.labelVrsta.Size = new System.Drawing.Size(57, 13);
            this.labelVrsta.TabIndex = 2;
            this.labelVrsta.Text = "Vrsta testa";
            // 
            // labelRezultat
            // 
            this.labelRezultat.AutoSize = true;
            this.labelRezultat.Location = new System.Drawing.Point(35, 153);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(46, 13);
            this.labelRezultat.TabIndex = 3;
            this.labelRezultat.Text = "Rezultat";
            // 
            // labelKomentar
            // 
            this.labelKomentar.AutoSize = true;
            this.labelKomentar.Location = new System.Drawing.Point(35, 193);
            this.labelKomentar.Name = "labelKomentar";
            this.labelKomentar.Size = new System.Drawing.Size(52, 13);
            this.labelKomentar.TabIndex = 4;
            this.labelKomentar.Text = "Komentar";
            // 
            // DodajTestforma
            // 
            this.ClientSize = new System.Drawing.Size(440, 300);
            this.Controls.Add(this.labelCV);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelVrsta);
            this.Controls.Add(this.labelRezultat);
            this.Controls.Add(this.labelKomentar);
            this.Controls.Add(this.cbKandidat);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbVrsta);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.tbKomentar);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnNazad);
            this.Name = "DodajTestforma";
            this.Text = "Dodaj test";
            this.Load += new System.EventHandler(this.DodajTestforma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cbKandidat;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbVrsta;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.TextBox tbKomentar;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelVrsta;
        private System.Windows.Forms.Label labelRezultat;
        private System.Windows.Forms.Label labelKomentar;
    }
}
