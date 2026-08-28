namespace SelekcijaKandidata.Forme
{
    partial class DodajOglasForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudMaxPlata = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumZatvaranja = new System.Windows.Forms.DateTimePicker();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelBrojTelefona = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumObjave = new System.Windows.Forms.DateTimePicker();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNazivPozicije = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVrstaOglasa = new System.Windows.Forms.ComboBox();
            this.nudMinPlata = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLokacija = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbProjekat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPeriodAngazovanja = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSezona = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudTrajanjeMeseci = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMentor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrajanjeMeseci)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Max plata";
            // 
            // nudMaxPlata
            // 
            this.nudMaxPlata.Location = new System.Drawing.Point(251, 170);
            this.nudMaxPlata.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMaxPlata.Name = "nudMaxPlata";
            this.nudMaxPlata.Size = new System.Drawing.Size(246, 20);
            this.nudMaxPlata.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Vrsta oglasa";
            // 
            // dtpDatumZatvaranja
            // 
            this.dtpDatumZatvaranja.Location = new System.Drawing.Point(251, 223);
            this.dtpDatumZatvaranja.Name = "dtpDatumZatvaranja";
            this.dtpDatumZatvaranja.Size = new System.Drawing.Size(246, 20);
            this.dtpDatumZatvaranja.TabIndex = 46;
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(239, 464);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(99, 23);
            this.btnOcisti.TabIndex = 45;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(239, 423);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(99, 23);
            this.btnDodaj.TabIndex = 44;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "aktivan",
            "zatvoren",
            "u toku selekcije"});
            this.cbStatus.Location = new System.Drawing.Point(251, 90);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(246, 21);
            this.cbStatus.TabIndex = 43;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(190, 95);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 16);
            this.labelStatus.TabIndex = 42;
            this.labelStatus.Text = "Status";
            // 
            // labelBrojTelefona
            // 
            this.labelBrojTelefona.AutoSize = true;
            this.labelBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrojTelefona.Location = new System.Drawing.Point(180, 143);
            this.labelBrojTelefona.Name = "labelBrojTelefona";
            this.labelBrojTelefona.Size = new System.Drawing.Size(61, 16);
            this.labelBrojTelefona.TabIndex = 41;
            this.labelBrojTelefona.Text = "Min plata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Naziv pozicije";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Opis";
            // 
            // dtpDatumObjave
            // 
            this.dtpDatumObjave.Location = new System.Drawing.Point(251, 196);
            this.dtpDatumObjave.Name = "dtpDatumObjave";
            this.dtpDatumObjave.Size = new System.Drawing.Size(246, 20);
            this.dtpDatumObjave.TabIndex = 38;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(251, 117);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(246, 20);
            this.tbOpis.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Datum objave";
            // 
            // tbNazivPozicije
            // 
            this.tbNazivPozicije.Location = new System.Drawing.Point(251, 39);
            this.tbNazivPozicije.Name = "tbNazivPozicije";
            this.tbNazivPozicije.Size = new System.Drawing.Size(246, 20);
            this.tbNazivPozicije.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Datum zatvaranja";
            // 
            // cbVrstaOglasa
            // 
            this.cbVrstaOglasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrstaOglasa.FormattingEnabled = true;
            this.cbVrstaOglasa.Items.AddRange(new object[] {
            "stalni rad",
            "privremeni rad",
            "sezonski rad",
            "praksa"});
            this.cbVrstaOglasa.Location = new System.Drawing.Point(251, 65);
            this.cbVrstaOglasa.Name = "cbVrstaOglasa";
            this.cbVrstaOglasa.Size = new System.Drawing.Size(246, 21);
            this.cbVrstaOglasa.TabIndex = 56;
            // 
            // nudMinPlata
            // 
            this.nudMinPlata.Location = new System.Drawing.Point(251, 143);
            this.nudMinPlata.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMinPlata.Name = "nudMinPlata";
            this.nudMinPlata.Size = new System.Drawing.Size(246, 20);
            this.nudMinPlata.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Lokacija";
            // 
            // tbLokacija
            // 
            this.tbLokacija.Location = new System.Drawing.Point(251, 301);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(246, 20);
            this.tbLokacija.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Projekat";
            // 
            // tbProjekat
            // 
            this.tbProjekat.Location = new System.Drawing.Point(251, 249);
            this.tbProjekat.Name = "tbProjekat";
            this.tbProjekat.Size = new System.Drawing.Size(246, 20);
            this.tbProjekat.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 63;
            this.label9.Text = "Period angazovanja";
            // 
            // tbPeriodAngazovanja
            // 
            this.tbPeriodAngazovanja.Location = new System.Drawing.Point(251, 275);
            this.tbPeriodAngazovanja.Name = "tbPeriodAngazovanja";
            this.tbPeriodAngazovanja.Size = new System.Drawing.Size(246, 20);
            this.tbPeriodAngazovanja.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(138, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Trajanje meseci";
            // 
            // tbSezona
            // 
            this.tbSezona.Location = new System.Drawing.Point(251, 332);
            this.tbSezona.Name = "tbSezona";
            this.tbSezona.Size = new System.Drawing.Size(246, 20);
            this.tbSezona.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(185, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 66;
            this.label11.Text = "Sezona";
            // 
            // nudTrajanjeMeseci
            // 
            this.nudTrajanjeMeseci.Location = new System.Drawing.Point(251, 364);
            this.nudTrajanjeMeseci.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTrajanjeMeseci.Name = "nudTrajanjeMeseci";
            this.nudTrajanjeMeseci.Size = new System.Drawing.Size(246, 20);
            this.nudTrajanjeMeseci.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(184, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 68;
            this.label12.Text = "Mentor";
            // 
            // cbMentor
            // 
            this.cbMentor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMentor.FormattingEnabled = true;
            this.cbMentor.Items.AddRange(new object[] {
            "izabran",
            "odbijen",
            "rezerva",
            "na cekanju"});
            this.cbMentor.Location = new System.Drawing.Point(251, 392);
            this.cbMentor.Name = "cbMentor";
            this.cbMentor.Size = new System.Drawing.Size(246, 21);
            this.cbMentor.TabIndex = 69;
            // 
            // DodajOglasForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 499);
            this.Controls.Add(this.cbMentor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudTrajanjeMeseci);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbSezona);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPeriodAngazovanja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbProjekat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLokacija);
            this.Controls.Add(this.nudMinPlata);
            this.Controls.Add(this.cbVrstaOglasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNazivPozicije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMaxPlata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumZatvaranja);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelBrojTelefona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumObjave);
            this.Controls.Add(this.tbOpis);
            this.Name = "DodajOglasForma";
            this.Text = "DodajOglasForma";
            this.Load += new System.EventHandler(this.DodajOglasForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrajanjeMeseci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMaxPlata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumZatvaranja;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelBrojTelefona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumObjave;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNazivPozicije;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVrstaOglasa;
        private System.Windows.Forms.NumericUpDown nudMinPlata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLokacija;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbProjekat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPeriodAngazovanja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSezona;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudTrajanjeMeseci;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMentor;
    }
}