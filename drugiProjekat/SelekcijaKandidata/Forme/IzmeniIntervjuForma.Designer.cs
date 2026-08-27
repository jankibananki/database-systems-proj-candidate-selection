namespace SelekcijaKandidata.Forme
{
    partial class IzmeniIntervjuForma
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
            this.components = new System.ComponentModel.Container();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnIzmeniIntervju = new System.Windows.Forms.Button();
            this.tbOcena = new System.Windows.Forms.TextBox();
            this.cbZaposleni = new System.Windows.Forms.ComboBox();
            this.tbLokacija = new System.Windows.Forms.TextBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.dtpDatumIVreme = new System.Windows.Forms.DateTimePicker();
            this.cbKandidat = new System.Windows.Forms.ComboBox();
            this.labelOcena = new System.Windows.Forms.Label();
            this.labelZaposleni = new System.Windows.Forms.Label();
            this.labelLokacija = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelDatumVreme = new System.Windows.Forms.Label();
            this.labelKandidat = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(231, 467);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(78, 23);
            this.btnNazad.TabIndex = 29;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(203, 417);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(137, 23);
            this.btnOcisti.TabIndex = 28;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // btnIzmeniIntervju
            // 
            this.btnIzmeniIntervju.Location = new System.Drawing.Point(203, 367);
            this.btnIzmeniIntervju.Name = "btnIzmeniIntervju";
            this.btnIzmeniIntervju.Size = new System.Drawing.Size(137, 23);
            this.btnIzmeniIntervju.TabIndex = 27;
            this.btnIzmeniIntervju.Text = "Izmeni Intervju";
            this.btnIzmeniIntervju.UseVisualStyleBackColor = true;
            this.btnIzmeniIntervju.Click += new System.EventHandler(this.btnIzmeniIntervju_Click);
            // 
            // tbOcena
            // 
            this.tbOcena.Location = new System.Drawing.Point(231, 306);
            this.tbOcena.Name = "tbOcena";
            this.tbOcena.Size = new System.Drawing.Size(201, 20);
            this.tbOcena.TabIndex = 26;
            // 
            // cbZaposleni
            // 
            this.cbZaposleni.FormattingEnabled = true;
            this.cbZaposleni.Location = new System.Drawing.Point(231, 264);
            this.cbZaposleni.Name = "cbZaposleni";
            this.cbZaposleni.Size = new System.Drawing.Size(201, 21);
            this.cbZaposleni.TabIndex = 25;
            // 
            // tbLokacija
            // 
            this.tbLokacija.Location = new System.Drawing.Point(231, 212);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(201, 20);
            this.tbLokacija.TabIndex = 24;
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(231, 167);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(201, 21);
            this.cbTip.TabIndex = 23;
            // 
            // dtpDatumIVreme
            // 
            this.dtpDatumIVreme.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatumIVreme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumIVreme.Location = new System.Drawing.Point(231, 116);
            this.dtpDatumIVreme.Name = "dtpDatumIVreme";
            this.dtpDatumIVreme.Size = new System.Drawing.Size(201, 20);
            this.dtpDatumIVreme.TabIndex = 22;
            // 
            // cbKandidat
            // 
            this.cbKandidat.FormattingEnabled = true;
            this.cbKandidat.Location = new System.Drawing.Point(231, 66);
            this.cbKandidat.Name = "cbKandidat";
            this.cbKandidat.Size = new System.Drawing.Size(201, 21);
            this.cbKandidat.TabIndex = 21;
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(108, 313);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(39, 13);
            this.labelOcena.TabIndex = 20;
            this.labelOcena.Text = "Ocena";
            // 
            // labelZaposleni
            // 
            this.labelZaposleni.AutoSize = true;
            this.labelZaposleni.Location = new System.Drawing.Point(108, 267);
            this.labelZaposleni.Name = "labelZaposleni";
            this.labelZaposleni.Size = new System.Drawing.Size(53, 13);
            this.labelZaposleni.TabIndex = 19;
            this.labelZaposleni.Text = "Zaposleni";
            // 
            // labelLokacija
            // 
            this.labelLokacija.AutoSize = true;
            this.labelLokacija.Location = new System.Drawing.Point(108, 215);
            this.labelLokacija.Name = "labelLokacija";
            this.labelLokacija.Size = new System.Drawing.Size(47, 13);
            this.labelLokacija.TabIndex = 18;
            this.labelLokacija.Text = "Lokacija";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(108, 168);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(65, 13);
            this.labelTip.TabIndex = 17;
            this.labelTip.Text = "Tip intervjua";
            // 
            // labelDatumVreme
            // 
            this.labelDatumVreme.AutoSize = true;
            this.labelDatumVreme.Location = new System.Drawing.Point(108, 123);
            this.labelDatumVreme.Name = "labelDatumVreme";
            this.labelDatumVreme.Size = new System.Drawing.Size(76, 13);
            this.labelDatumVreme.TabIndex = 16;
            this.labelDatumVreme.Text = "Datum i Vreme";
            // 
            // labelKandidat
            // 
            this.labelKandidat.AutoSize = true;
            this.labelKandidat.Location = new System.Drawing.Point(108, 69);
            this.labelKandidat.Name = "labelKandidat";
            this.labelKandidat.Size = new System.Drawing.Size(49, 13);
            this.labelKandidat.TabIndex = 15;
            this.labelKandidat.Text = "Kandidat";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // IzmeniIntervjuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 556);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnIzmeniIntervju);
            this.Controls.Add(this.tbOcena);
            this.Controls.Add(this.cbZaposleni);
            this.Controls.Add(this.tbLokacija);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.dtpDatumIVreme);
            this.Controls.Add(this.cbKandidat);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.labelZaposleni);
            this.Controls.Add(this.labelLokacija);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelDatumVreme);
            this.Controls.Add(this.labelKandidat);
            this.Name = "IzmeniIntervjuForma";
            this.Text = "IzmeniIntervjuForma";
            this.Load += new System.EventHandler(this.IzmeniIntervjuForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnIzmeniIntervju;
        private System.Windows.Forms.TextBox tbOcena;
        private System.Windows.Forms.ComboBox cbZaposleni;
        private System.Windows.Forms.TextBox tbLokacija;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.DateTimePicker dtpDatumIVreme;
        private System.Windows.Forms.ComboBox cbKandidat;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Label labelZaposleni;
        private System.Windows.Forms.Label labelLokacija;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelDatumVreme;
        private System.Windows.Forms.Label labelKandidat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}