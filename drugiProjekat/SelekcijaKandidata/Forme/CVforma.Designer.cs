namespace SelekcijaKandidata.Forme
{
    partial class CVforma
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
            this.dgvCV = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatumPodnosenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labeldgvCV = new System.Windows.Forms.Label();
            this.btnDodajCV = new System.Windows.Forms.Button();
            this.labelCV = new System.Windows.Forms.Label();
            this.btnIzmeniCV = new System.Windows.Forms.Button();
            this.btnObrisiCV = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCV
            // 
            this.dgvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colIme,
            this.colPrezime,
            this.colEmail,
            this.colDatumPodnosenja,
            this.colStatus,
            this.colBrojTelefona});
            this.dgvCV.Location = new System.Drawing.Point(12, 75);
            this.dgvCV.MultiSelect = false;
            this.dgvCV.Name = "dgvCV";
            this.dgvCV.ReadOnly = true;
            this.dgvCV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCV.Size = new System.Drawing.Size(739, 428);
            this.dgvCV.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colIme
            // 
            this.colIme.DataPropertyName = "Ime";
            this.colIme.HeaderText = "Ime";
            this.colIme.Name = "colIme";
            this.colIme.ReadOnly = true;
            // 
            // colPrezime
            // 
            this.colPrezime.DataPropertyName = "Prezime";
            this.colPrezime.HeaderText = "Prezime";
            this.colPrezime.Name = "colPrezime";
            this.colPrezime.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colDatumPodnosenja
            // 
            this.colDatumPodnosenja.DataPropertyName = "DatumPodnosenja";
            this.colDatumPodnosenja.HeaderText = "Datum Podnošenja";
            this.colDatumPodnosenja.Name = "colDatumPodnosenja";
            this.colDatumPodnosenja.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colBrojTelefona
            // 
            this.colBrojTelefona.DataPropertyName = "BrojTelefona";
            this.colBrojTelefona.HeaderText = "BrojTelefona";
            this.colBrojTelefona.Name = "colBrojTelefona";
            this.colBrojTelefona.ReadOnly = true;
            // 
            // labeldgvCV
            // 
            this.labeldgvCV.AutoSize = true;
            this.labeldgvCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldgvCV.Location = new System.Drawing.Point(6, 41);
            this.labeldgvCV.Name = "labeldgvCV";
            this.labeldgvCV.Size = new System.Drawing.Size(209, 31);
            this.labeldgvCV.TabIndex = 1;
            this.labeldgvCV.Text = "Prikaz podataka";
            // 
            // btnDodajCV
            // 
            this.btnDodajCV.Location = new System.Drawing.Point(782, 81);
            this.btnDodajCV.Name = "btnDodajCV";
            this.btnDodajCV.Size = new System.Drawing.Size(142, 34);
            this.btnDodajCV.TabIndex = 2;
            this.btnDodajCV.Text = "Dodaj CV";
            this.btnDodajCV.UseVisualStyleBackColor = true;
            this.btnDodajCV.Click += new System.EventHandler(this.btnDodajCV_Click);
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCV.Location = new System.Drawing.Point(380, 9);
            this.labelCV.Name = "labelCV";
            this.labelCV.Size = new System.Drawing.Size(128, 39);
            this.labelCV.TabIndex = 3;
            this.labelCV.Text = "CV-evi";
            // 
            // btnIzmeniCV
            // 
            this.btnIzmeniCV.Location = new System.Drawing.Point(782, 141);
            this.btnIzmeniCV.Name = "btnIzmeniCV";
            this.btnIzmeniCV.Size = new System.Drawing.Size(142, 34);
            this.btnIzmeniCV.TabIndex = 4;
            this.btnIzmeniCV.Text = "Izmeni CV";
            this.btnIzmeniCV.UseVisualStyleBackColor = true;
            this.btnIzmeniCV.Click += new System.EventHandler(this.btnIzmeniCV_Click);
            // 
            // btnObrisiCV
            // 
            this.btnObrisiCV.Location = new System.Drawing.Point(782, 199);
            this.btnObrisiCV.Name = "btnObrisiCV";
            this.btnObrisiCV.Size = new System.Drawing.Size(142, 34);
            this.btnObrisiCV.TabIndex = 5;
            this.btnObrisiCV.Text = "Obriši CV";
            this.btnObrisiCV.UseVisualStyleBackColor = true;
            this.btnObrisiCV.Click += new System.EventHandler(this.btnObrisiCV_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(832, 502);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(99, 23);
            this.btnNazad.TabIndex = 15;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // CVforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 537);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnObrisiCV);
            this.Controls.Add(this.btnIzmeniCV);
            this.Controls.Add(this.labelCV);
            this.Controls.Add(this.btnDodajCV);
            this.Controls.Add(this.labeldgvCV);
            this.Controls.Add(this.dgvCV);
            this.Name = "CVforma";
            this.Text = "CVforma";
            this.Load += new System.EventHandler(this.CVforma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCV;
        private System.Windows.Forms.Label labeldgvCV;
        private System.Windows.Forms.Button btnDodajCV;
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.Button btnIzmeniCV;
        private System.Windows.Forms.Button btnObrisiCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumPodnosenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrojTelefona;
        private System.Windows.Forms.Button btnNazad;
    }
}