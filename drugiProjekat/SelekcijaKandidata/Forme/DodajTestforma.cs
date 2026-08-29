using NHibernate;
using NHibernate.Linq;
using SelekcijaKandidata.Entiteti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SelekcijaKandidata.Forme
{
    public partial class DodajTestforma : Form
    {
        public DodajTestforma()
        {
            InitializeComponent();
        }

        private void DodajTestforma_Load(object sender, EventArgs e)
        {
            PopuniKandidate();
        }

        private void PopuniKandidate()
        {
            try
            {
                var kandidati = DTOManager.VratiKandidate();
                cbKandidat.DataSource = kandidati;
                cbKandidat.DisplayMember = "Kandidat";
                cbKandidat.ValueMember = "Id";
                cbKandidat.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbKandidat.SelectedItem == null)
            {
                MessageBox.Show("Izaberite kandidata.");
                return;
            }

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
                var izabraniKandidat = (CVLookup)cbKandidat.SelectedItem;

                DTOManager.DodajTest(new TestBasic
                {
                    Datum = dtpDatum.Value.Date,
                    Vrsta = tbVrsta.Text.Trim(),
                    Rezultat = rezultat,
                    Komentar = tbKomentar.Text.Trim(),
                    IdCV = izabraniKandidat.Id
                });

                MessageBox.Show("Test je uspesno dodat.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbVrsta.Clear();
            tbRezultat.Clear();
            tbKomentar.Clear();
            dtpDatum.Value = DateTime.Today;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
