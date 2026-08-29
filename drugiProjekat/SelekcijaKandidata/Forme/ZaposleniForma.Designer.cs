namespace SelekcijaKandidata.Forme
{
    partial class ZaposleniForma
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
            this.btnObrisiZaposlenog = new System.Windows.Forms.Button();
            this.btnIzmeniZaposlenog = new System.Windows.Forms.Button();
            this.labelOglas = new System.Windows.Forms.Label();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.labeldgvCV = new System.Windows.Forms.Label();
            this.dgvZaposleni = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaposleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiZaposlenog
            // 
            this.btnObrisiZaposlenog.Location = new System.Drawing.Point(788, 211);
            this.btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            this.btnObrisiZaposlenog.Size = new System.Drawing.Size(142, 34);
            this.btnObrisiZaposlenog.TabIndex = 17;
            this.btnObrisiZaposlenog.Text = "Obriši zaposlenog";
            this.btnObrisiZaposlenog.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenog.Click += new System.EventHandler(this.btnObrisiZaposlenog_Click);
            // 
            // btnIzmeniZaposlenog
            // 
            this.btnIzmeniZaposlenog.Location = new System.Drawing.Point(788, 153);
            this.btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            this.btnIzmeniZaposlenog.Size = new System.Drawing.Size(142, 34);
            this.btnIzmeniZaposlenog.TabIndex = 16;
            this.btnIzmeniZaposlenog.Text = "Izmeni zaposlenog";
            this.btnIzmeniZaposlenog.UseVisualStyleBackColor = true;
            this.btnIzmeniZaposlenog.Click += new System.EventHandler(this.btnIzmeniZaposlenog_Click);
            // 
            // labelOglas
            // 
            this.labelOglas.AutoSize = true;
            this.labelOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOglas.Location = new System.Drawing.Point(386, 21);
            this.labelOglas.Name = "labelOglas";
            this.labelOglas.Size = new System.Drawing.Size(176, 39);
            this.labelOglas.TabIndex = 15;
            this.labelOglas.Text = "Zaposleni";
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(788, 93);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(142, 34);
            this.btnDodajZaposlenog.TabIndex = 14;
            this.btnDodajZaposlenog.Text = "Dodaj zaposlenog";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // labeldgvCV
            // 
            this.labeldgvCV.AutoSize = true;
            this.labeldgvCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldgvCV.Location = new System.Drawing.Point(12, 53);
            this.labeldgvCV.Name = "labeldgvCV";
            this.labeldgvCV.Size = new System.Drawing.Size(209, 31);
            this.labeldgvCV.TabIndex = 13;
            this.labeldgvCV.Text = "Prikaz podataka";
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Zaposleni});
            this.dgvZaposleni.Location = new System.Drawing.Point(18, 87);
            this.dgvZaposleni.MultiSelect = false;
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.ReadOnly = true;
            this.dgvZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposleni.Size = new System.Drawing.Size(739, 428);
            this.dgvZaposleni.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Zaposleni
            // 
            this.Zaposleni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zaposleni.DataPropertyName = "Zaposleni";
            this.Zaposleni.HeaderText = "Ime i prezime";
            this.Zaposleni.Name = "Zaposleni";
            this.Zaposleni.ReadOnly = true;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(845, 492);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 18;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // ZaposleniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 537);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnObrisiZaposlenog);
            this.Controls.Add(this.btnIzmeniZaposlenog);
            this.Controls.Add(this.labelOglas);
            this.Controls.Add(this.btnDodajZaposlenog);
            this.Controls.Add(this.labeldgvCV);
            this.Controls.Add(this.dgvZaposleni);
            this.Name = "ZaposleniForma";
            this.Text = "ZaposleniForma";
            this.Load += new System.EventHandler(this.ZaposleniForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiZaposlenog;
        private System.Windows.Forms.Button btnIzmeniZaposlenog;
        private System.Windows.Forms.Label labelOglas;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.Label labeldgvCV;
        private System.Windows.Forms.DataGridView dgvZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposleni;
        private System.Windows.Forms.Button btnNazad;
    }
}