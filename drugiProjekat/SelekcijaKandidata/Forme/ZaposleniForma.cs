using System;
using System.Windows.Forms;

namespace SelekcijaKandidata.Forme
{
    public partial class ZaposleniForma : Form
    {
        public ZaposleniForma()
        {
            InitializeComponent();
            dgvZaposleni.AutoGenerateColumns = false;
        }

        private void ZaposleniForma_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                dgvZaposleni.DataSource = DTOManager.VratiZaposlene();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            var forma = new DodajZaposlenogForma();
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte zaposlenog za brisanje.");
                return;
            }

            var izabran = (ZaposleniLookup)dgvZaposleni.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Obrisati zaposlenog {izabran.Zaposleni}?",
                "Potvrda", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                DTOManager.ObrisiZaposlenog(izabran.Id);
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
