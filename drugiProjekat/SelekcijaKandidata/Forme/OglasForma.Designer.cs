namespace SelekcijaKandidata.Forme
{
    partial class OglasForma
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
            this.btnObrisiOglas = new System.Windows.Forms.Button();
            this.btnIzmeniOglas = new System.Windows.Forms.Button();
            this.labelOglas = new System.Windows.Forms.Label();
            this.btnDodajOglas = new System.Windows.Forms.Button();
            this.labeldgvCV = new System.Windows.Forms.Label();
            this.dgvOglasi = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPozicije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaOglasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPlata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPlata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZatvaranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiOglas
            // 
            this.btnObrisiOglas.Location = new System.Drawing.Point(782, 199);
            this.btnObrisiOglas.Name = "btnObrisiOglas";
            this.btnObrisiOglas.Size = new System.Drawing.Size(142, 34);
            this.btnObrisiOglas.TabIndex = 11;
            this.btnObrisiOglas.Text = "Obriši oglas";
            this.btnObrisiOglas.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniOglas
            // 
            this.btnIzmeniOglas.Location = new System.Drawing.Point(782, 141);
            this.btnIzmeniOglas.Name = "btnIzmeniOglas";
            this.btnIzmeniOglas.Size = new System.Drawing.Size(142, 34);
            this.btnIzmeniOglas.TabIndex = 10;
            this.btnIzmeniOglas.Text = "Izmeni oglas";
            this.btnIzmeniOglas.UseVisualStyleBackColor = true;
            // 
            // labelOglas
            // 
            this.labelOglas.AutoSize = true;
            this.labelOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOglas.Location = new System.Drawing.Point(380, 9);
            this.labelOglas.Name = "labelOglas";
            this.labelOglas.Size = new System.Drawing.Size(122, 39);
            this.labelOglas.TabIndex = 9;
            this.labelOglas.Text = "Oglasi";
            // 
            // btnDodajOglas
            // 
            this.btnDodajOglas.Location = new System.Drawing.Point(782, 81);
            this.btnDodajOglas.Name = "btnDodajOglas";
            this.btnDodajOglas.Size = new System.Drawing.Size(142, 34);
            this.btnDodajOglas.TabIndex = 8;
            this.btnDodajOglas.Text = "Dodaj oglas";
            this.btnDodajOglas.UseVisualStyleBackColor = true;
            this.btnDodajOglas.Click += new System.EventHandler(this.btnDodajOglas_Click);
            // 
            // labeldgvCV
            // 
            this.labeldgvCV.AutoSize = true;
            this.labeldgvCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldgvCV.Location = new System.Drawing.Point(6, 41);
            this.labeldgvCV.Name = "labeldgvCV";
            this.labeldgvCV.Size = new System.Drawing.Size(209, 31);
            this.labeldgvCV.TabIndex = 7;
            this.labeldgvCV.Text = "Prikaz podataka";
            // 
            // dgvOglasi
            // 
            this.dgvOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOglasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.NazivPozicije,
            this.VrstaOglasa,
            this.Opis,
            this.MinPlata,
            this.MaxPlata,
            this.DatumObjave,
            this.DatumZatvaranja,
            this.Status});
            this.dgvOglasi.Location = new System.Drawing.Point(12, 75);
            this.dgvOglasi.MultiSelect = false;
            this.dgvOglasi.Name = "dgvOglasi";
            this.dgvOglasi.ReadOnly = true;
            this.dgvOglasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOglasi.Size = new System.Drawing.Size(739, 428);
            this.dgvOglasi.TabIndex = 6;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // NazivPozicije
            // 
            this.NazivPozicije.DataPropertyName = "NazivPozicije";
            this.NazivPozicije.HeaderText = "Naziv pozicije";
            this.NazivPozicije.Name = "NazivPozicije";
            this.NazivPozicije.ReadOnly = true;
            // 
            // VrstaOglasa
            // 
            this.VrstaOglasa.DataPropertyName = "VrstaOglasa";
            this.VrstaOglasa.HeaderText = "Vrsta oglasa";
            this.VrstaOglasa.Name = "VrstaOglasa";
            this.VrstaOglasa.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // MinPlata
            // 
            this.MinPlata.DataPropertyName = "MinPlata";
            this.MinPlata.HeaderText = "Min Plata";
            this.MinPlata.Name = "MinPlata";
            this.MinPlata.ReadOnly = true;
            // 
            // MaxPlata
            // 
            this.MaxPlata.DataPropertyName = "MaxPlata";
            this.MaxPlata.HeaderText = "Max Plata";
            this.MaxPlata.Name = "MaxPlata";
            this.MaxPlata.ReadOnly = true;
            // 
            // DatumObjave
            // 
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "Datum Objave";
            this.DatumObjave.Name = "DatumObjave";
            this.DatumObjave.ReadOnly = true;
            // 
            // DatumZatvaranja
            // 
            this.DatumZatvaranja.DataPropertyName = "DatumZatvaranja";
            this.DatumZatvaranja.HeaderText = "Datum Zatvaranja";
            this.DatumZatvaranja.Name = "DatumZatvaranja";
            this.DatumZatvaranja.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // OglasForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 537);
            this.Controls.Add(this.btnObrisiOglas);
            this.Controls.Add(this.btnIzmeniOglas);
            this.Controls.Add(this.labelOglas);
            this.Controls.Add(this.btnDodajOglas);
            this.Controls.Add(this.labeldgvCV);
            this.Controls.Add(this.dgvOglasi);
            this.Name = "OglasForma";
            this.Text = "OglasForma";
            this.Load += new System.EventHandler(this.OglasForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiOglas;
        private System.Windows.Forms.Button btnIzmeniOglas;
        private System.Windows.Forms.Label labelOglas;
        private System.Windows.Forms.Button btnDodajOglas;
        private System.Windows.Forms.Label labeldgvCV;
        private System.Windows.Forms.DataGridView dgvOglasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPozicije;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaOglasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPlata;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPlata;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZatvaranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}