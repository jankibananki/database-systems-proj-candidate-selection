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
        private Test test;

        public IzmeniTestForma(Test test)
        {
            InitializeComponent();
            this.test = test;
        }

        private void IzmeniTestForma_Load(object sender, EventArgs e)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    IList<CV> cvjevi = s.QueryOver<CV>().List<CV>();

                    cbCV.DataSource = cvjevi;
                    cbCV.DisplayMember = "KandidatPrikaz";
                    cbCV.ValueMember = "Id";
                    cbCV.SelectedValue = test.CV.Id;
                }

                dtpDatum.Value = test.Datum;
                tbVrsta.Text = test.Vrsta;
                tbRezultat.Text = test.Rezultat.HasValue
                    ? test.Rezultat.Value.ToString()
                    : "";
                tbKomentar.Text = test.Komentar;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cbCV.SelectedItem == null || string.IsNullOrWhiteSpace(tbVrsta.Text))
            {
                MessageBox.Show("Izaberite kandidata i unesite vrstu testa.");
                return;
            }

            try
            {
                test.Datum = dtpDatum.Value;
                test.Vrsta = tbVrsta.Text.Trim();
                test.Rezultat = string.IsNullOrWhiteSpace(tbRezultat.Text)
                    ? (int?)null
                    : int.Parse(tbRezultat.Text);
                test.Komentar = tbKomentar.Text.Trim();
                test.CV = (CV)cbCV.SelectedItem;

                using (ISession s = DataLayer.GetSession())
                using (ITransaction tx = s.BeginTransaction())
                {
                    s.Update(test);
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
    }
}
