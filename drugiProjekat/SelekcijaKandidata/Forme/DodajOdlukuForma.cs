using NHibernate;
using NHibernate.Linq;
using SelekcijaKandidata.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                ISession s = DataLayer.GetSession();

                var cvjevi = s.Query<CV>().ToList();

                cbCV.DataSource = cvjevi;
                cbCV.DisplayMember = "Id";

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PopuniStatuse()
        {
            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(new object[] { "izabran", "odbijen", "rezerva", "na cekanju" });
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odluka novaOdluka = new Odluka()
                {
                    Datum = dtpDatum.Value.Date,
                    PocetakRada = dtpPocetakRada.Value.Date,
                    Prihvaceno = cbPrihvaceno.Checked ? 1 : 0,
                    Status = cbStatus.SelectedItem?.ToString(),
                    Plata = nudPlata.Value,
                    RazlogOdbijanja = tbRazlogOdbijanja.Text.Trim(),
                    CV = (CV)cbCV.SelectedItem
                };

                s.Save(novaOdluka);
                s.Flush();
                s.Close();

                MessageBox.Show("Odluka je uspešno dodata.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {

        }
    }
}
