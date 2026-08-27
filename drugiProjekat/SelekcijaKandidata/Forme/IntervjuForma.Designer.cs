namespace SelekcijaKandidata.Forme
{
    partial class IntervjuForma
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
            this.btnObrisiIntervju = new System.Windows.Forms.Button();
            this.btnIzmeniIntervju = new System.Windows.Forms.Button();
            this.labelCV = new System.Windows.Forms.Label();
            this.btnDodajIntervju = new System.Windows.Forms.Button();
            this.labeldgvCV = new System.Windows.Forms.Label();
            this.dgvIntervju = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKandidat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZaposleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOcena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNapomene = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.colNapomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.btnDodajNapomenu = new System.Windows.Forms.Button();
            this.btnObrisiNapomenu = new System.Windows.Forms.Button();
            this.btnIzmeniNapomenu = new System.Windows.Forms.Button();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervju)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiIntervju
            // 
            this.btnObrisiIntervju.Location = new System.Drawing.Point(916, 166);
            this.btnObrisiIntervju.Name = "btnObrisiIntervju";
            this.btnObrisiIntervju.Size = new System.Drawing.Size(142, 34);
            this.btnObrisiIntervju.TabIndex = 11;
            this.btnObrisiIntervju.Text = "Obriši Intervju";
            this.btnObrisiIntervju.UseVisualStyleBackColor = true;
            this.btnObrisiIntervju.Click += new System.EventHandler(this.btnObrisiIntervju_Click);
            // 
            // btnIzmeniIntervju
            // 
            this.btnIzmeniIntervju.Location = new System.Drawing.Point(916, 108);
            this.btnIzmeniIntervju.Name = "btnIzmeniIntervju";
            this.btnIzmeniIntervju.Size = new System.Drawing.Size(142, 34);
            this.btnIzmeniIntervju.TabIndex = 10;
            this.btnIzmeniIntervju.Text = "Izmeni Intervju";
            this.btnIzmeniIntervju.UseVisualStyleBackColor = true;
            this.btnIzmeniIntervju.Click += new System.EventHandler(this.btnIzmeniIntervju_Click);
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCV.Location = new System.Drawing.Point(389, 16);
            this.labelCV.Name = "labelCV";
            this.labelCV.Size = new System.Drawing.Size(148, 39);
            this.labelCV.TabIndex = 9;
            this.labelCV.Text = "Intervjui";
            // 
            // btnDodajIntervju
            // 
            this.btnDodajIntervju.Location = new System.Drawing.Point(916, 48);
            this.btnDodajIntervju.Name = "btnDodajIntervju";
            this.btnDodajIntervju.Size = new System.Drawing.Size(142, 34);
            this.btnDodajIntervju.TabIndex = 8;
            this.btnDodajIntervju.Text = "Dodaj Intervju";
            this.btnDodajIntervju.UseVisualStyleBackColor = true;
            this.btnDodajIntervju.Click += new System.EventHandler(this.btnDodajIntervju_Click);
            // 
            // labeldgvCV
            // 
            this.labeldgvCV.AutoSize = true;
            this.labeldgvCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldgvCV.Location = new System.Drawing.Point(15, 48);
            this.labeldgvCV.Name = "labeldgvCV";
            this.labeldgvCV.Size = new System.Drawing.Size(209, 31);
            this.labeldgvCV.TabIndex = 7;
            this.labeldgvCV.Text = "Prikaz podataka";
            // 
            // dgvIntervju
            // 
            this.dgvIntervju.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervju.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colKandidat,
            this.colDatum,
            this.colTip,
            this.colLokacija,
            this.colZaposleni,
            this.colOcena});
            this.dgvIntervju.Location = new System.Drawing.Point(21, 82);
            this.dgvIntervju.MultiSelect = false;
            this.dgvIntervju.Name = "dgvIntervju";
            this.dgvIntervju.ReadOnly = true;
            this.dgvIntervju.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntervju.Size = new System.Drawing.Size(739, 475);
            this.dgvIntervju.TabIndex = 6;
            this.dgvIntervju.SelectionChanged += new System.EventHandler(this.dgvIntervju_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colKandidat
            // 
            this.colKandidat.DataPropertyName = "Kandidat";
            this.colKandidat.HeaderText = "Kandidat";
            this.colKandidat.Name = "colKandidat";
            this.colKandidat.ReadOnly = true;
            // 
            // colDatum
            // 
            this.colDatum.DataPropertyName = "DatumIVreme";
            this.colDatum.HeaderText = "Datum i vreme";
            this.colDatum.Name = "colDatum";
            this.colDatum.ReadOnly = true;
            // 
            // colTip
            // 
            this.colTip.DataPropertyName = "Tip";
            this.colTip.HeaderText = "Tip";
            this.colTip.Name = "colTip";
            this.colTip.ReadOnly = true;
            // 
            // colLokacija
            // 
            this.colLokacija.DataPropertyName = "Lokacija";
            this.colLokacija.HeaderText = "Lokacija";
            this.colLokacija.Name = "colLokacija";
            this.colLokacija.ReadOnly = true;
            // 
            // colZaposleni
            // 
            this.colZaposleni.DataPropertyName = "Zaposleni";
            this.colZaposleni.HeaderText = "Zaposleni";
            this.colZaposleni.Name = "colZaposleni";
            this.colZaposleni.ReadOnly = true;
            // 
            // colOcena
            // 
            this.colOcena.DataPropertyName = "Ocena";
            this.colOcena.HeaderText = "Ocena";
            this.colOcena.Name = "colOcena";
            this.colOcena.ReadOnly = true;
            // 
            // dgvNapomene
            // 
            this.dgvNapomene.AllowUserToAddRows = false;
            this.dgvNapomene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNapomene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNapomena});
            this.dgvNapomene.Location = new System.Drawing.Point(777, 252);
            this.dgvNapomene.MultiSelect = false;
            this.dgvNapomene.Name = "dgvNapomene";
            this.dgvNapomene.ReadOnly = true;
            this.dgvNapomene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNapomene.Size = new System.Drawing.Size(409, 210);
            this.dgvNapomene.TabIndex = 12;
            this.dgvNapomene.SelectionChanged += new System.EventHandler(this.dgvNapomene_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Napomene za selektovan intervju";
            // 
            // colNapomena
            // 
            this.colNapomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNapomena.DataPropertyName = "Napomena";
            this.colNapomena.HeaderText = "Napomena";
            this.colNapomena.Name = "colNapomena";
            this.colNapomena.ReadOnly = true;
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(674, 48);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(86, 31);
            this.btnOsvezi.TabIndex = 14;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // btnDodajNapomenu
            // 
            this.btnDodajNapomenu.Location = new System.Drawing.Point(777, 523);
            this.btnDodajNapomenu.Name = "btnDodajNapomenu";
            this.btnDodajNapomenu.Size = new System.Drawing.Size(124, 34);
            this.btnDodajNapomenu.TabIndex = 15;
            this.btnDodajNapomenu.Text = "Dodaj Napomenu";
            this.btnDodajNapomenu.UseVisualStyleBackColor = true;
            this.btnDodajNapomenu.Click += new System.EventHandler(this.btnDodajNapomenu_Click);
            // 
            // btnObrisiNapomenu
            // 
            this.btnObrisiNapomenu.Location = new System.Drawing.Point(1062, 523);
            this.btnObrisiNapomenu.Name = "btnObrisiNapomenu";
            this.btnObrisiNapomenu.Size = new System.Drawing.Size(124, 34);
            this.btnObrisiNapomenu.TabIndex = 16;
            this.btnObrisiNapomenu.Text = "Obriši Napomenu";
            this.btnObrisiNapomenu.UseVisualStyleBackColor = true;
            this.btnObrisiNapomenu.Click += new System.EventHandler(this.btnObrisiNapomenu_Click);
            // 
            // btnIzmeniNapomenu
            // 
            this.btnIzmeniNapomenu.Location = new System.Drawing.Point(907, 523);
            this.btnIzmeniNapomenu.Name = "btnIzmeniNapomenu";
            this.btnIzmeniNapomenu.Size = new System.Drawing.Size(151, 34);
            this.btnIzmeniNapomenu.TabIndex = 17;
            this.btnIzmeniNapomenu.Text = "Izmeni Napomenu";
            this.btnIzmeniNapomenu.UseVisualStyleBackColor = true;
            this.btnIzmeniNapomenu.Click += new System.EventHandler(this.btnIzmeniNapomenu_Click);
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(777, 497);
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(409, 20);
            this.tbNapomena.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Unesi ili izmeni izabranu napomenu";
            // 
            // IntervjuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.btnIzmeniNapomenu);
            this.Controls.Add(this.btnObrisiNapomenu);
            this.Controls.Add(this.btnDodajNapomenu);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNapomene);
            this.Controls.Add(this.btnObrisiIntervju);
            this.Controls.Add(this.btnIzmeniIntervju);
            this.Controls.Add(this.labelCV);
            this.Controls.Add(this.btnDodajIntervju);
            this.Controls.Add(this.labeldgvCV);
            this.Controls.Add(this.dgvIntervju);
            this.Name = "IntervjuForma";
            this.Text = "IntervjuForma";
            this.Load += new System.EventHandler(this.IntervjuForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervju)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiIntervju;
        private System.Windows.Forms.Button btnIzmeniIntervju;
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.Button btnDodajIntervju;
        private System.Windows.Forms.Label labeldgvCV;
        private System.Windows.Forms.DataGridView dgvIntervju;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKandidat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOcena;
        private System.Windows.Forms.DataGridView dgvNapomene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNapomena;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Button btnDodajNapomenu;
        private System.Windows.Forms.Button btnObrisiNapomenu;
        private System.Windows.Forms.Button btnIzmeniNapomenu;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.Label label2;
    }
}