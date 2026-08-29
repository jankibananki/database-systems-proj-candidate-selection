namespace SelekcijaKandidata.Forme
{
    partial class TestForma
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
            this.dgvTestovi = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatumPodnosenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajTest = new System.Windows.Forms.Button();
            this.btnObrisiTest = new System.Windows.Forms.Button();
            this.btnIzmeniTest = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.labelCV = new System.Windows.Forms.Label();
            this.labeldgvCV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTestovi
            // 
            this.dgvTestovi.ColumnHeadersHeight = 29;
            this.dgvTestovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colIme,
            this.colPrezime,
            this.colEmail,
            this.colDatumPodnosenja,
            this.colStatus,
            this.colBrojTelefona});
            this.dgvTestovi.Location = new System.Drawing.Point(12, 75);
            this.dgvTestovi.MultiSelect = false;
            this.dgvTestovi.Name = "dgvTestovi";
            this.dgvTestovi.ReadOnly = true;
            this.dgvTestovi.RowHeadersWidth = 51;
            this.dgvTestovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestovi.Size = new System.Drawing.Size(739, 428);
            this.dgvTestovi.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // colIme
            // 
            this.colIme.DataPropertyName = "Datum";
            this.colIme.HeaderText = "Datum";
            this.colIme.MinimumWidth = 6;
            this.colIme.Name = "colIme";
            this.colIme.ReadOnly = true;
            this.colIme.Width = 125;
            // 
            // colPrezime
            // 
            this.colPrezime.DataPropertyName = "Vrsta";
            this.colPrezime.HeaderText = "Vrsta";
            this.colPrezime.MinimumWidth = 6;
            this.colPrezime.Name = "colPrezime";
            this.colPrezime.ReadOnly = true;
            this.colPrezime.Width = 125;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Rezultat";
            this.colEmail.HeaderText = "Rezultat";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 125;
            // 
            // colDatumPodnosenja
            // 
            this.colDatumPodnosenja.DataPropertyName = "Komentar";
            this.colDatumPodnosenja.HeaderText = "Komentar";
            this.colDatumPodnosenja.MinimumWidth = 6;
            this.colDatumPodnosenja.Name = "colDatumPodnosenja";
            this.colDatumPodnosenja.ReadOnly = true;
            this.colDatumPodnosenja.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "CV";
            this.colStatus.HeaderText = "Kandidat";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // colBrojTelefona
            // 
            this.colBrojTelefona.HeaderText = "";
            this.colBrojTelefona.MinimumWidth = 6;
            this.colBrojTelefona.Name = "colBrojTelefona";
            this.colBrojTelefona.ReadOnly = true;
            this.colBrojTelefona.Width = 125;
            // 
            // btnDodajTest
            // 
            this.btnDodajTest.Location = new System.Drawing.Point(757, 75);
            this.btnDodajTest.Name = "btnDodajTest";
            this.btnDodajTest.Size = new System.Drawing.Size(176, 49);
            this.btnDodajTest.TabIndex = 2;
            this.btnDodajTest.Text = "Dodaj test";
            this.btnDodajTest.Click += new System.EventHandler(this.btnDodajTest_Click);
            // 
            // btnObrisiTest
            // 
            this.btnObrisiTest.Location = new System.Drawing.Point(757, 185);
            this.btnObrisiTest.Name = "btnObrisiTest";
            this.btnObrisiTest.Size = new System.Drawing.Size(176, 49);
            this.btnObrisiTest.TabIndex = 0;
            this.btnObrisiTest.Text = "Obriši test";
            this.btnObrisiTest.Click += new System.EventHandler(this.btnObrisiTest_Click);
            // 
            // btnIzmeniTest
            // 
            this.btnIzmeniTest.Location = new System.Drawing.Point(757, 130);
            this.btnIzmeniTest.Name = "btnIzmeniTest";
            this.btnIzmeniTest.Size = new System.Drawing.Size(176, 49);
            this.btnIzmeniTest.TabIndex = 3;
            this.btnIzmeniTest.Text = "Izmeni test";
            this.btnIzmeniTest.Click += new System.EventHandler(this.btnIzmeniTest_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(812, 483);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(71, 20);
            this.btnNazad.TabIndex = 13;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCV.Location = new System.Drawing.Point(386, 7);
            this.labelCV.Name = "labelCV";
            this.labelCV.Size = new System.Drawing.Size(137, 39);
            this.labelCV.TabIndex = 15;
            this.labelCV.Text = "Testovi";
            // 
            // labeldgvCV
            // 
            this.labeldgvCV.AutoSize = true;
            this.labeldgvCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldgvCV.Location = new System.Drawing.Point(12, 39);
            this.labeldgvCV.Name = "labeldgvCV";
            this.labeldgvCV.Size = new System.Drawing.Size(209, 31);
            this.labeldgvCV.TabIndex = 14;
            this.labeldgvCV.Text = "Prikaz podataka";
            // 
            // TestForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 537);
            this.Controls.Add(this.labelCV);
            this.Controls.Add(this.labeldgvCV);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnIzmeniTest);
            this.Controls.Add(this.btnObrisiTest);
            this.Controls.Add(this.btnDodajTest);
            this.Controls.Add(this.dgvTestovi);
            this.Name = "TestForma";
            this.Text = "Testovi";
            this.Load += new System.EventHandler(this.TestForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTestovi;
        private System.Windows.Forms.Button btnDodajTest;
        private System.Windows.Forms.Button btnObrisiTest;
        private System.Windows.Forms.Button btnIzmeniTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumPodnosenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrojTelefona;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.Label labeldgvCV;
    }
}