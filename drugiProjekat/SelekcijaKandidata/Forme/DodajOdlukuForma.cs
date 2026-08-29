using System;
using System.Linq;
using System.Windows.Forms;

namespace SelekcijaKandidata.Forme
{
    public partial class DodajOdlukuForma : Form
    {
        public DodajOdlukuForma()
        {
            InitializeComponent();
            UcitajCV();
            dtpPocetakRada.Enabled = false;
            nudPlata.Enabled = false;
            tbRazlogOdbijanja.Enabled = false;
            dtpDatum.MinDate = DateTime.Today;
            dtpPocetakRada.MinDate = DateTime.Today;
            cbPrihvaceno.CheckedChanged += cbPrihvaceno_CheckedChanged;
            dtpDatum.ValueChanged += dtpDatum_ValueChanged;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
        }

        private void UcitajCV()
        {
            try
            {
                var cvjevi = DTOManager.VratiSveCV();
                cbCV.DataSource = cvjevi;
                cbCV.DisplayMember = "Id";
                cbCV.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbCV.SelectedItem == null)
            {
                MessageBox.Show("Izaberite CV.");
                return;
            }
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
                var izabraniCv = (CVPregled)cbCV.SelectedItem;

                var dto = new OdlukaBasic
                {
                    Datum = dtpDatum.Value.Date,
                    PocetakRada = cbPrihvaceno.Checked ? dtpPocetakRada.Value.Date : (DateTime?)null,
                    Prihvaceno = cbPrihvaceno.Checked ? 1 : 0,
                    Status = cbStatus.SelectedItem.ToString(),
                    Plata = nudPlata.Value,
                    RazlogOdbijanja = cbPrihvaceno.Checked ? null : tbRazlogOdbijanja.Text.Trim(),
                    IdCV = izabraniCv.Id
                };

                DTOManager.DodajOdluku(dto);

                MessageBox.Show("Odluka je uspesno dodata.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            dtpDatum.Value = DateTime.Today;
            dtpPocetakRada.Value = DateTime.Today;
            cbStatus.SelectedIndex = -1;
            nudPlata.Value = 0;
            tbRazlogOdbijanja.Clear();
            cbPrihvaceno.Checked = false;
            cbCV.SelectedIndex = -1;
            cbPrihvaceno_CheckedChanged(null, EventArgs.Empty);
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

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}