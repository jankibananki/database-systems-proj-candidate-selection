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
            this.cbCV = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbVrsta = new System.Windows.Forms.TextBox();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.tbKomentar = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.cbCV.Location = new System.Drawing.Point(150, 30); this.cbCV.Size = new System.Drawing.Size(250, 21);
            this.dtpDatum.Location = new System.Drawing.Point(150, 70); this.dtpDatum.Size = new System.Drawing.Size(250, 20);
            this.tbVrsta.Location = new System.Drawing.Point(150, 110); this.tbVrsta.Size = new System.Drawing.Size(250, 20);
            this.tbRezultat.Location = new System.Drawing.Point(150, 150); this.tbRezultat.Size = new System.Drawing.Size(250, 20);
            this.tbKomentar.Location = new System.Drawing.Point(150, 190); this.tbKomentar.Size = new System.Drawing.Size(250, 20);
            System.Windows.Forms.Label labelCV = new System.Windows.Forms.Label(); labelCV.Text = "Kandidat"; labelCV.Location = new System.Drawing.Point(35, 33); labelCV.AutoSize = true;
            System.Windows.Forms.Label labelDatum = new System.Windows.Forms.Label(); labelDatum.Text = "Datum"; labelDatum.Location = new System.Drawing.Point(35, 73); labelDatum.AutoSize = true;
            System.Windows.Forms.Label labelVrsta = new System.Windows.Forms.Label(); labelVrsta.Text = "Vrsta testa"; labelVrsta.Location = new System.Drawing.Point(35, 113); labelVrsta.AutoSize = true;
            System.Windows.Forms.Label labelRezultat = new System.Windows.Forms.Label(); labelRezultat.Text = "Rezultat"; labelRezultat.Location = new System.Drawing.Point(35, 153); labelRezultat.AutoSize = true;
            System.Windows.Forms.Label labelKomentar = new System.Windows.Forms.Label(); labelKomentar.Text = "Komentar"; labelKomentar.Location = new System.Drawing.Point(35, 193); labelKomentar.AutoSize = true;
            this.btnDodaj.Location = new System.Drawing.Point(35, 240); this.btnDodaj.Size = new System.Drawing.Size(95, 25); this.btnDodaj.Text = "Dodaj"; this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            this.btnOcisti.Location = new System.Drawing.Point(145, 240); this.btnOcisti.Size = new System.Drawing.Size(95, 25); this.btnOcisti.Text = "Očisti"; this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            this.btnNazad.Location = new System.Drawing.Point(255, 240); this.btnNazad.Size = new System.Drawing.Size(95, 25); this.btnNazad.Text = "Nazad"; this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            this.ClientSize = new System.Drawing.Size(440, 300);
            this.Controls.Add(labelCV); this.Controls.Add(labelDatum); this.Controls.Add(labelVrsta); this.Controls.Add(labelRezultat); this.Controls.Add(labelKomentar);
            this.Controls.Add(this.cbCV); this.Controls.Add(this.dtpDatum); this.Controls.Add(this.tbVrsta); this.Controls.Add(this.tbRezultat); this.Controls.Add(this.tbKomentar); this.Controls.Add(this.btnDodaj); this.Controls.Add(this.btnOcisti); this.Controls.Add(this.btnNazad);
            this.Name = "DodajTestforma"; this.Text = "Dodaj test"; this.Load += new System.EventHandler(this.DodajTestforma_Load);
            this.ResumeLayout(false); this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cbCV;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbVrsta;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.TextBox tbKomentar;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnNazad;
    }
}
