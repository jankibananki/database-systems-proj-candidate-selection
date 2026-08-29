namespace SelekcijaKandidata.Forme
{
    partial class DodajOdlukuForma
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
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelBrojTelefona = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbRazlogOdbijanja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPocetakRada = new System.Windows.Forms.DateTimePicker();
            this.cbPrihvaceno = new System.Windows.Forms.CheckBox();
            this.nudPlata = new System.Windows.Forms.NumericUpDown();
            this.cbCV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(254, 246);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(99, 23);
            this.btnOcisti.TabIndex = 28;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(254, 217);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(99, 23);
            this.btnDodaj.TabIndex = 27;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "izabran",
            "odbijen",
            "rezerva",
            "na cekanju"});
            this.cbStatus.Location = new System.Drawing.Point(267, 61);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(246, 21);
            this.cbStatus.TabIndex = 26;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(139, 66);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 16);
            this.labelStatus.TabIndex = 25;
            this.labelStatus.Text = "Status";
            // 
            // labelBrojTelefona
            // 
            this.labelBrojTelefona.AutoSize = true;
            this.labelBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrojTelefona.Location = new System.Drawing.Point(139, 128);
            this.labelBrojTelefona.Name = "labelBrojTelefona";
            this.labelBrojTelefona.Size = new System.Drawing.Size(109, 16);
            this.labelBrojTelefona.TabIndex = 24;
            this.labelBrojTelefona.Text = "Razlog odbijanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Plata";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(267, 6);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(246, 20);
            this.dtpDatum.TabIndex = 19;
            // 
            // tbRazlogOdbijanja
            // 
            this.tbRazlogOdbijanja.Location = new System.Drawing.Point(267, 124);
            this.tbRazlogOdbijanja.Name = "tbRazlogOdbijanja";
            this.tbRazlogOdbijanja.Size = new System.Drawing.Size(246, 20);
            this.tbRazlogOdbijanja.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pocetak rada";
            // 
            // dtpPocetakRada
            // 
            this.dtpPocetakRada.Location = new System.Drawing.Point(267, 32);
            this.dtpPocetakRada.Name = "dtpPocetakRada";
            this.dtpPocetakRada.Size = new System.Drawing.Size(246, 20);
            this.dtpPocetakRada.TabIndex = 30;
            // 
            // cbPrihvaceno
            // 
            this.cbPrihvaceno.AutoSize = true;
            this.cbPrihvaceno.Location = new System.Drawing.Point(142, 185);
            this.cbPrihvaceno.Name = "cbPrihvaceno";
            this.cbPrihvaceno.Size = new System.Drawing.Size(80, 17);
            this.cbPrihvaceno.TabIndex = 33;
            this.cbPrihvaceno.Text = "Prihvaceno";
            this.cbPrihvaceno.UseVisualStyleBackColor = true;
            // 
            // nudPlata
            // 
            this.nudPlata.Location = new System.Drawing.Point(267, 94);
            this.nudPlata.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPlata.Name = "nudPlata";
            this.nudPlata.Size = new System.Drawing.Size(246, 20);
            this.nudPlata.TabIndex = 34;
            // 
            // cbCV
            // 
            this.cbCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCV.FormattingEnabled = true;
            this.cbCV.Location = new System.Drawing.Point(267, 159);
            this.cbCV.Name = "cbCV";
            this.cbCV.Size = new System.Drawing.Size(246, 21);
            this.cbCV.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kandidat";
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(267, 287);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 25);
            this.btnNazad.TabIndex = 37;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // DodajOdlukuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 324);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCV);
            this.Controls.Add(this.nudPlata);
            this.Controls.Add(this.cbPrihvaceno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPocetakRada);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelBrojTelefona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbRazlogOdbijanja);
            this.Name = "DodajOdlukuForma";
            this.Text = "DodajOdlukuForma";
            ((System.ComponentModel.ISupportInitialize)(this.nudPlata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelBrojTelefona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbRazlogOdbijanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPocetakRada;
        private System.Windows.Forms.CheckBox cbPrihvaceno;
        private System.Windows.Forms.NumericUpDown nudPlata;
        private System.Windows.Forms.ComboBox cbCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNazad;
    }
}