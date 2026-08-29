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
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    IList<CV> cvjevi = s.QueryOver<CV>().List<CV>();
                    cbCV.DataSource = cvjevi;
                    cbCV.DisplayMember = "KandidatPrikaz";
                    cbCV.ValueMember = "Id";
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbCV.SelectedItem == null || string.IsNullOrWhiteSpace(tbVrsta.Text))
            {
                MessageBox.Show("Izaberite kandidata i unesite vrstu testa.");
                return;
            }

            try
            {
                Test test = new Test
                {
                    Datum = dtpDatum.Value,
                    Vrsta = tbVrsta.Text.Trim(),
                    Rezultat = string.IsNullOrWhiteSpace(tbRezultat.Text) ? (int?)null : int.Parse(tbRezultat.Text),
                    Komentar = tbKomentar.Text.Trim(),
                    CV = (CV)cbCV.SelectedItem
                };

                using (ISession s = DataLayer.GetSession())
                using (ITransaction tx = s.BeginTransaction())
                {
                    s.Save(test);
                    tx.Commit();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Rezultat mora biti ceo broj ili prazan.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
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
