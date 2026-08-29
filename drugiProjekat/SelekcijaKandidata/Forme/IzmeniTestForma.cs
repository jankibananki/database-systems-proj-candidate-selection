using NHibernate;
using NHibernate.Linq;
using SelekcijaKandidata.Entiteti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SelekcijaKandidata.Forme
{
    public partial class IzmeniTestForma : Form
    {
        private readonly TestPregled test;

        public IzmeniTestForma(TestPregled test)
        {
            InitializeComponent();
            this.test = test;
        }

        private void IzmeniTestForma_Load(object sender, EventArgs e)
        {
            if (test == null)
                return;

            PopuniKandidate();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            cbKandidat.SelectedValue = test.IdCV;
            dtpDatum.Value = test.Datum;
            tbVrsta.Text = test.Vrsta;
            tbRezultat.Text = test.Rezultat?.ToString() ?? "";
            tbKomentar.Text = test.Komentar;
        }

        private void PopuniKandidate()
        {
            try
            {
                var kandidati = DTOManager.VratiKandidate();
                cbKandidat.DataSource = kandidati;
                cbKandidat.DisplayMember = "Kandidat";
                cbKandidat.ValueMember = "Id";
                cbKandidat.Enabled = false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbVrsta.Text))
            {
                MessageBox.Show("Unesite vrstu testa.");
                return;
            }

            int? rezultat = null;
            if (!string.IsNullOrWhiteSpace(tbRezultat.Text))
            {
                if (!int.TryParse(tbRezultat.Text, out int r))
                {
                    MessageBox.Show("Rezultat mora biti ceo broj.");
                    return;
                }
                rezultat = r;
            }

            try
            {
                DTOManager.IzmeniTest(new TestBasic
                {
                    Id = test.Id,
                    Datum = dtpDatum.Value.Date,
                    Vrsta = tbVrsta.Text.Trim(),
                    Rezultat = rezultat,
                    Komentar = tbKomentar.Text.Trim(),
                    IdCV = test.IdCV
                });

                MessageBox.Show("Test je uspesno izmenjen.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
