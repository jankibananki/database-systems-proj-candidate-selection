using System;
using System.Windows.Forms;

namespace SelekcijaKandidata.Forme
{
    public partial class OdlukaForma : Form
    {
        public OdlukaForma()
        {
            InitializeComponent();
            dgvOdluke.AutoGenerateColumns = false;
            dgvOdluke.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colKandidat",
                HeaderText = "Kandidat",
                DataPropertyName = "ImePrezimeKandidata"
            });
        }

        private void OdlukaForma_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                dgvOdluke.DataSource = DTOManager.VratiSveOdluke();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajOdluku_Click(object sender, EventArgs e)
        {
            var forma = new DodajOdlukuForma();
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private void btnIzmeniOdluku_Click(object sender, EventArgs e)
        {
            
        }

        private void btnObrisiOdluku_Click_1(object sender, EventArgs e)
        {
            if (dgvOdluke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte odluku za brisanje.");
                return;
            }

            var izabrana = (OdlukaBasic)dgvOdluke.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Obrisati odluku (Id={izabrana.Id})?",
                "Brisanje odluke", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                DTOManager.ObrisiOdluku(izabrana.Id);
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}