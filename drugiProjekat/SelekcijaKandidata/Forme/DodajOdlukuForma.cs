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
            PopuniStatuse();
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

        private void PopuniStatuse()
        {
            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(new object[] { "izabran", "odbijen", "rezerva", "na cekanju" });
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
            if (!cbPrihvaceno.Checked && string.IsNullOrWhiteSpace(tbRazlogOdbijanja.Text))
            {
                MessageBox.Show("Unesite razlog odbijanja.");
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
        }
    }
}