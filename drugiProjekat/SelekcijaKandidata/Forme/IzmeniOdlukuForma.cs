using System;
using System.Windows.Forms;

namespace SelekcijaKandidata.Forme
{
    public partial class IzmeniOdlukuForma : Form
    {
        private readonly OdlukaBasic _odluka;

        public IzmeniOdlukuForma(OdlukaBasic odluka)
        {
            InitializeComponent();
            _odluka = odluka;
            dtpPocetakRada.Enabled = false;
            nudPlata.Enabled = false;
            tbRazlogOdbijanja.Enabled = false;
            cbPrihvaceno.CheckedChanged += cbPrihvaceno_CheckedChanged;
            dtpDatum.ValueChanged += dtpDatum_ValueChanged;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
        }

        private void IzmeniOdlukuForma_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dtpDatum.Value = _odluka.Datum;
            dtpPocetakRada.Value = _odluka.PocetakRada ?? DateTime.Today;
            cbStatus.SelectedItem = _odluka.Status;
            nudPlata.Value = _odluka.Plata ?? 0;
            tbRazlogOdbijanja.Text = _odluka.RazlogOdbijanja;
            cbPrihvaceno.Checked = _odluka.Prihvaceno == 1;
            lblKandidat.Text = _odluka.ImePrezimeKandidata;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Izaberite status.");
                return;
            }
            if (cbStatus.SelectedItem?.ToString() == "odbijen" && string.IsNullOrWhiteSpace(tbRazlogOdbijanja.Text))
            {
                MessageBox.Show("Unesite razlog odbijanja.");
                tbRazlogOdbijanja.Focus();
                return;
            }
            try
            {
                _odluka.Datum = dtpDatum.Value.Date;
                _odluka.PocetakRada = cbPrihvaceno.Checked ? dtpPocetakRada.Value.Date : (DateTime?)null;
                _odluka.Prihvaceno = cbPrihvaceno.Checked ? 1 : 0;
                _odluka.Status = cbStatus.SelectedItem.ToString();
                _odluka.Plata = nudPlata.Value;
                _odluka.RazlogOdbijanja = cbPrihvaceno.Checked ? null : tbRazlogOdbijanja.Text.Trim();

                DTOManager.IzmeniOdluku(_odluka);

                MessageBox.Show("Odluka je uspesno izmenjena.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbPrihvaceno_CheckedChanged(object sender, EventArgs e)
        {
            bool prihvaceno = cbPrihvaceno.Checked;

            dtpPocetakRada.Enabled = prihvaceno;
            nudPlata.Enabled = prihvaceno;

            if (prihvaceno)
            {
                tbRazlogOdbijanja.Clear();
                dtpPocetakRada.MinDate = dtpDatum.Value.Date;
            }
            else
            {
                nudPlata.Value = 0;
                dtpPocetakRada.Value = dtpDatum.Value.Date;
            }
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            dtpPocetakRada.MinDate = dtpDatum.Value.Date;

            if (dtpPocetakRada.Value.Date < dtpDatum.Value.Date)
            {
                dtpPocetakRada.Value = dtpDatum.Value.Date;
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool odbijen = cbStatus.SelectedItem?.ToString() == "odbijen";

            tbRazlogOdbijanja.Enabled = odbijen;

            if (!odbijen)
                tbRazlogOdbijanja.Clear();
        }
    }
}
