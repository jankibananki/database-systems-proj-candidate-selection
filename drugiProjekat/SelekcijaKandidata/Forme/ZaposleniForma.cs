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
            this.Hide();
            var forma = new DodajZaposlenogForma();
            forma.ShowDialog();
            this.Show();
            UcitajPodatke();
        }

        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite zaposlenog kojeg želite da izmenite."
                );

                return;
            }

            int id = Convert.ToInt32(
                dgvZaposleni.SelectedRows[0]
                             .Cells["Id"]
                             .Value
            );

            this.Hide();
            var forma = new IzmeniZaposlenogForma(id);
            forma.ShowDialog();
            this.Show();
            UcitajPodatke();
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

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
