namespace SelekcijaKandidata.Forme
{
    partial class IzmeniOdlukuForma
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
            this.lblKandidat = new System.Windows.Forms.Label();
            this.nudPlata = new System.Windows.Forms.NumericUpDown();
            this.cbPrihvaceno = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPocetakRada = new System.Windows.Forms.DateTimePicker();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelBrojTelefona = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbRazlogOdbijanja = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKandidat
            // 
            this.lblKandidat.AutoSize = true;
            this.lblKandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKandidat.Location = new System.Drawing.Point(275, 159);
            this.lblKandidat.Name = "lblKandidat";
            this.lblKandidat.Size = new System.Drawing.Size(25, 16);
            this.lblKandidat.TabIndex = 51;
            this.lblKandidat.Text = "CV";
            // 
            // nudPlata
            // 
            this.nudPlata.Location = new System.Drawing.Point(252, 96);
            this.nudPlata.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPlata.Name = "nudPlata";
            this.nudPlata.Size = new System.Drawing.Size(246, 20);
            this.nudPlata.TabIndex = 49;
            // 
            // cbPrihvaceno
            // 
            this.cbPrihvaceno.AutoSize = true;
            this.cbPrihvaceno.Location = new System.Drawing.Point(127, 187);
            this.cbPrihvaceno.Name = "cbPrihvaceno";
            this.cbPrihvaceno.Size = new System.Drawing.Size(80, 17);
            this.cbPrihvaceno.TabIndex = 48;
            this.cbPrihvaceno.Text = "Prihvaceno";
            this.cbPrihvaceno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Pocetak rada";
            // 
            // dtpPocetakRada
            // 
            this.dtpPocetakRada.Location = new System.Drawing.Point(252, 34);
            this.dtpPocetakRada.Name = "dtpPocetakRada";
            this.dtpPocetakRada.Size = new System.Drawing.Size(246, 20);
            this.dtpPocetakRada.TabIndex = 46;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(239, 219);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(99, 23);
            this.btnIzmeni.TabIndex = 44;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
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
            this.cbStatus.Location = new System.Drawing.Point(252, 63);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(246, 21);
            this.cbStatus.TabIndex = 43;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(124, 68);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 16);
            this.labelStatus.TabIndex = 42;
            this.labelStatus.Text = "Status";
            // 
            // labelBrojTelefona
            // 
            this.labelBrojTelefona.AutoSize = true;
            this.labelBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrojTelefona.Location = new System.Drawing.Point(124, 130);
            this.labelBrojTelefona.Name = "labelBrojTelefona";
            this.labelBrojTelefona.Size = new System.Drawing.Size(109, 16);
            this.labelBrojTelefona.TabIndex = 41;
            this.labelBrojTelefona.Text = "Razlog odbijanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Plata";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(252, 8);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(246, 20);
            this.dtpDatum.TabIndex = 38;
            // 
            // tbRazlogOdbijanja
            // 
            this.tbRazlogOdbijanja.Location = new System.Drawing.Point(252, 126);
            this.tbRazlogOdbijanja.Name = "tbRazlogOdbijanja";
            this.tbRazlogOdbijanja.Size = new System.Drawing.Size(246, 20);
            this.tbRazlogOdbijanja.TabIndex = 37;
            // 
            // IzmeniOdlukuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 295);
            this.Controls.Add(this.lblKandidat);
            this.Controls.Add(this.nudPlata);
            this.Controls.Add(this.cbPrihvaceno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPocetakRada);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelBrojTelefona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbRazlogOdbijanja);
            this.Name = "IzmeniOdlukuForma";
            this.Text = "IzmeniOdlukuForma";
            this.Load += new System.EventHandler(this.IzmeniOdlukuForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKandidat;
        private System.Windows.Forms.NumericUpDown nudPlata;
        private System.Windows.Forms.CheckBox cbPrihvaceno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPocetakRada;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelBrojTelefona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbRazlogOdbijanja;
    }
}