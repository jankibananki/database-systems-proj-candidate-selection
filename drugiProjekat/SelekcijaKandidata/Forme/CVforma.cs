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
    public partial class CVforma : Form
    {
        public CVforma()
        {
            InitializeComponent();

            dgvCV.AutoGenerateColumns = false;
        }

        private void CVforma_Load(object sender, EventArgs e)
        {
            UcitajCV();
        }

        private void UcitajCV()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<CV> cvjevi = s.QueryOver<CV>()
                                    .OrderBy(x => x.Id).Asc
                                    .List<CV>();

                dgvCV.DataSource = cvjevi;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public void OsveziCV()
        {
            UcitajCV();
        }

        private void btnDodajCV_Click(object sender, EventArgs e)
        {
            DodajCVforma forma = new DodajCVforma(this);

            this.Hide();
            forma.Show();
        }

        private void btnIzmeniCV_Click(object sender, EventArgs e)
        {
            if (dgvCV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite CV koji želite da izmenite.");
                return;
            }

            CV izabraniCV = (CV)dgvCV.SelectedRows[0].DataBoundItem;

            IzmeniCVforma forma = new IzmeniCVforma(this, izabraniCV.Id);

            this.Hide();
            forma.Show();
        }

        private void btnObrisiCV_Click(object sender, EventArgs e)
        {
            if (dgvCV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite CV koji želite da obrišete.");
                return;
            }

            CV izabraniCV = (CV)dgvCV.SelectedRows[0].DataBoundItem;

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete izabrani CV?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat != DialogResult.Yes)
                return;

            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction tr = s.BeginTransaction())
                {
                    CV cv = s.Get<CV>(izabraniCV.Id);

                    if (cv == null)
                    {
                        MessageBox.Show("CV nije pronađen.");
                        return;
                    }

                    foreach (Intervju intervju in cv.Intervjui.ToList())
                    {
                        foreach (NapomenaIntervju napomena in intervju.Napomene.ToList())
                        {
                            s.Delete(napomena);
                        }

                        s.Delete(intervju);
                    }

                    foreach (Test test in cv.Testovi.ToList())
                    {
                        s.Delete(test);
                    }

                    Odluka odluka = s.QueryOver<Odluka>()
                     .Where(x => x.CV.Id == cv.Id)
                     .SingleOrDefault();

                    if (odluka != null)
                    {
                        s.Delete(odluka);
                    }

                    s.Delete(cv);

                    tr.Commit();
                }

                MessageBox.Show("CV je uspešno obrisan.");

                UcitajCV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
