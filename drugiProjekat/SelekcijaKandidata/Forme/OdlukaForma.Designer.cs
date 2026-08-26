namespace SelekcijaKandidata.Forme
{
    partial class OdlukaForma
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
            this.btnObrisiOdluku = new System.Windows.Forms.Button();
            this.btnIzmeniOdluku = new System.Windows.Forms.Button();
            this.labelOdluka = new System.Windows.Forms.Label();
            this.btnDodajOdluku = new System.Windows.Forms.Button();
            this.labeldgvCV = new System.Windows.Forms.Label();
            this.dgvOdluke = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetakRada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prihvaceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazlogOdbijanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdluke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiOdluku
            // 
            this.btnObrisiOdluku.Location = new System.Drawing.Point(788, 211);
            this.btnObrisiOdluku.Name = "btnObrisiOdluku";
            this.btnObrisiOdluku.Size = new System.Drawing.Size(142, 34);
            this.btnObrisiOdluku.TabIndex = 17;
            this.btnObrisiOdluku.Text = "Obriši odluku";
            this.btnObrisiOdluku.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniOdluku
            // 
            this.btnIzmeniOdluku.Location = new System.Drawing.Point(788, 153);
            this.btnIzmeniOdluku.Name = "btnIzmeniOdluku";
            this.btnIzmeniOdluku.Size = new System.Drawing.Size(142, 34);
            this.btnIzmeniOdluku.TabIndex = 16;
            this.btnIzmeniOdluku.Text = "Izmeni odluku";
            this.btnIzmeniOdluku.UseVisualStyleBackColor = true;
            // 
            // labelOdluka
            // 
            this.labelOdluka.AutoSize = true;
            this.labelOdluka.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOdluka.Location = new System.Drawing.Point(386, 21);
            this.labelOdluka.Name = "labelOdluka";
            this.labelOdluka.Size = new System.Drawing.Size(133, 39);
            this.labelOdluka.TabIndex = 15;
            this.labelOdluka.Text = "Odluke";
            // 
            // btnDodajOdluku
            // 
            this.btnDodajOdluku.Location = new System.Drawing.Point(788, 93);
            this.btnDodajOdluku.Name = "btnDodajOdluku";
            this.btnDodajOdluku.Size = new System.Drawing.Size(142, 34);
            this.btnDodajOdluku.TabIndex = 14;
            this.btnDodajOdluku.Text = "Dodaj odluku";
            this.btnDodajOdluku.UseVisualStyleBackColor = true;
            this.btnDodajOdluku.Click += new System.EventHandler(this.btnDodajOdluku_Click);
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
            // dgvOdluke
            // 
            this.dgvOdluke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdluke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.Datum,
            this.PocetakRada,
            this.Prihvaceno,
            this.Status,
            this.Plata,
            this.RazlogOdbijanja});
            this.dgvOdluke.Location = new System.Drawing.Point(18, 87);
            this.dgvOdluke.MultiSelect = false;
            this.dgvOdluke.Name = "dgvOdluke";
            this.dgvOdluke.ReadOnly = true;
            this.dgvOdluke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdluke.Size = new System.Drawing.Size(739, 428);
            this.dgvOdluke.TabIndex = 12;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // PocetakRada
            // 
            this.PocetakRada.DataPropertyName = "PocetakRada";
            this.PocetakRada.HeaderText = "Pocetak rada";
            this.PocetakRada.Name = "PocetakRada";
            this.PocetakRada.ReadOnly = true;
            // 
            // Prihvaceno
            // 
            this.Prihvaceno.DataPropertyName = "Prihvaceno";
            this.Prihvaceno.HeaderText = "Prihvaceno";
            this.Prihvaceno.Name = "Prihvaceno";
            this.Prihvaceno.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Plata
            // 
            this.Plata.DataPropertyName = "Plata";
            this.Plata.HeaderText = "Plata";
            this.Plata.Name = "Plata";
            this.Plata.ReadOnly = true;
            // 
            // RazlogOdbijanja
            // 
            this.RazlogOdbijanja.DataPropertyName = "RazlogOdbijanja";
            this.RazlogOdbijanja.HeaderText = "Razlog odbijanja";
            this.RazlogOdbijanja.Name = "RazlogOdbijanja";
            this.RazlogOdbijanja.ReadOnly = true;
            // 
            // OdlukaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 537);
            this.Controls.Add(this.btnObrisiOdluku);
            this.Controls.Add(this.btnIzmeniOdluku);
            this.Controls.Add(this.labelOdluka);
            this.Controls.Add(this.btnDodajOdluku);
            this.Controls.Add(this.labeldgvCV);
            this.Controls.Add(this.dgvOdluke);
            this.Name = "OdlukaForma";
            this.Text = "OdlukaForma";
            this.Load += new System.EventHandler(this.OdlukaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdluke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiOdluku;
        private System.Windows.Forms.Button btnIzmeniOdluku;
        private System.Windows.Forms.Label labelOdluka;
        private System.Windows.Forms.Button btnDodajOdluku;
        private System.Windows.Forms.Label labeldgvCV;
        private System.Windows.Forms.DataGridView dgvOdluke;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetakRada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prihvaceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plata;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazlogOdbijanja;
    }
}