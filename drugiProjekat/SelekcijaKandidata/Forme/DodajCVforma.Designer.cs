namespace SelekcijaKandidata.Forme
{
    partial class DodajCVforma
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbBrojTelefona = new System.Windows.Forms.TextBox();
            this.dtpDatumPodnosenja = new System.Windows.Forms.DateTimePicker();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBrojTelefona = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.labeOglas = new System.Windows.Forms.Label();
            this.cbOglas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(195, 38);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(246, 20);
            this.tbIme.TabIndex = 0;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(195, 93);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(246, 20);
            this.tbPrezime.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(195, 152);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(246, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // tbBrojTelefona
            // 
            this.tbBrojTelefona.Location = new System.Drawing.Point(195, 336);
            this.tbBrojTelefona.Name = "tbBrojTelefona";
            this.tbBrojTelefona.Size = new System.Drawing.Size(246, 20);
            this.tbBrojTelefona.TabIndex = 3;
            // 
            // dtpDatumPodnosenja
            // 
            this.dtpDatumPodnosenja.Location = new System.Drawing.Point(195, 210);
            this.dtpDatumPodnosenja.Name = "dtpDatumPodnosenja";
            this.dtpDatumPodnosenja.Size = new System.Drawing.Size(246, 20);
            this.dtpDatumPodnosenja.TabIndex = 4;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIme.Location = new System.Drawing.Point(67, 39);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(29, 16);
            this.labelIme.TabIndex = 5;
            this.labelIme.Text = "Ime";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrezime.Location = new System.Drawing.Point(67, 97);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(56, 16);
            this.labelPrezime.TabIndex = 6;
            this.labelPrezime.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum Podnošenja";
            // 
            // labelBrojTelefona
            // 
            this.labelBrojTelefona.AutoSize = true;
            this.labelBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrojTelefona.Location = new System.Drawing.Point(67, 340);
            this.labelBrojTelefona.Name = "labelBrojTelefona";
            this.labelBrojTelefona.Size = new System.Drawing.Size(88, 16);
            this.labelBrojTelefona.TabIndex = 9;
            this.labelBrojTelefona.Text = "Broj Telefona";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(67, 278);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 16);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(195, 273);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(246, 21);
            this.cbStatus.TabIndex = 11;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(182, 465);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(99, 23);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(182, 506);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(99, 23);
            this.btnOcisti.TabIndex = 13;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(182, 547);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(99, 23);
            this.btnNazad.TabIndex = 14;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // labeOglas
            // 
            this.labeOglas.AutoSize = true;
            this.labeOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeOglas.Location = new System.Drawing.Point(67, 403);
            this.labeOglas.Name = "labeOglas";
            this.labeOglas.Size = new System.Drawing.Size(43, 16);
            this.labeOglas.TabIndex = 15;
            this.labeOglas.Text = "Oglas";
            // 
            // cbOglas
            // 
            this.cbOglas.FormattingEnabled = true;
            this.cbOglas.Location = new System.Drawing.Point(195, 398);
            this.cbOglas.Name = "cbOglas";
            this.cbOglas.Size = new System.Drawing.Size(246, 21);
            this.cbOglas.TabIndex = 16;
            // 
            // DodajCVforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 605);
            this.Controls.Add(this.cbOglas);
            this.Controls.Add(this.labeOglas);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelBrojTelefona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.dtpDatumPodnosenja);
            this.Controls.Add(this.tbBrojTelefona);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Name = "DodajCVforma";
            this.Text = "DodajCVforma";
            this.Load += new System.EventHandler(this.DodajCVforma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbBrojTelefona;
        private System.Windows.Forms.DateTimePicker dtpDatumPodnosenja;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBrojTelefona;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label labeOglas;
        private System.Windows.Forms.ComboBox cbOglas;
    }
}