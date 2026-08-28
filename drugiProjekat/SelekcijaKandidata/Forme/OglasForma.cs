using NHibernate;
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
    public partial class OglasForma : Form
    {
        private string stariZahtev;
        public OglasForma()
        {
            InitializeComponent();
            dgvOglasi.AutoGenerateColumns = false;
            dgvZahtevi.AutoGenerateColumns = false;
        }

        private void OglasForma_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                dgvOglasi.DataSource = DTOManager.VratiSveOglase(); 
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajOglas_Click(object sender, EventArgs e)
        {
            var forma = new DodajOglasForma();
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private void btnObrisiOglas_Click(object sender, EventArgs e)
        {
            if (dgvOglasi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte oglas za brisanje.");
                return;
            }

            var izabran = (OglasPregled)dgvOglasi.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Obrisati oglas (Id={izabran.Id})?",
                "Brisanje oglasa", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                DTOManager.ObrisiOglas(izabran.Id);
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnIzmeniOglas_Click(object sender, EventArgs e)
        {
            if (dgvOglasi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte oglas za izmenu.");
                return;
            }

            var izabran = (OglasPregled)dgvOglasi.SelectedRows[0].DataBoundItem;

            var forma = new IzmeniOglasForma(izabran);
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private int? VratiIdSelektovanogOglasa()
        {
            if (dgvOglasi.SelectedRows.Count == 0)
                return null;

            OglasPregled oglas =
                dgvOglasi.SelectedRows[0].DataBoundItem as OglasPregled;

            if (oglas == null)
                return null;

            return oglas.Id;
        }

        private void UcitajZahteve(int idOglasa)
        {
            try
            {
                dgvZahtevi.DataSource =
                    DTOManager.VratiZahteveOglasa(idOglasa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOglasi_SelectionChanged(object sender, EventArgs e)
        {
            int? idOglasa = VratiIdSelektovanogOglasa();

            if (idOglasa == null)
            {
                dgvZahtevi.DataSource = null;
                tbZahtev.Clear();
                stariZahtev = null;
                return;
            }

            UcitajZahteve(idOglasa.Value);

            tbZahtev.Clear();
            stariZahtev = null;
        }

        private void dgvZahtevi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZahtevi.SelectedRows.Count == 0)
            {
                tbZahtev.Clear();
                stariZahtev = null;
                return;
            }

            ZahtevOglasBasic zahtev =
                dgvZahtevi.SelectedRows[0].DataBoundItem as ZahtevOglasBasic;

            if (zahtev == null)
                return;

            stariZahtev = zahtev.Zahtev;
            tbZahtev.Text = zahtev.Zahtev;
        }

        private void btnDodajZahtev_Click(object sender, EventArgs e)
        {
            int? idOglasa = VratiIdSelektovanogOglasa();

            if (idOglasa == null)
            {
                MessageBox.Show("Izaberite oglas.");
                return;
            }

            string tekst = tbZahtev.Text.Trim();

            if (string.IsNullOrWhiteSpace(tekst))
            {
                MessageBox.Show("Unesite zahtev.");
                return;
            }

            if (tekst.Length > 30)
            {
                MessageBox.Show("Zahtev može imati najviše 30 karaktera.");
                return;
            }

            try
            {
                DTOManager.DodajZahtev(
                    idOglasa.Value,
                    tekst
                );

                MessageBox.Show("Zahtev je uspešno dodat.");

                UcitajZahteve(idOglasa.Value);

                tbZahtev.Clear();
                stariZahtev = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeniZahtev_Click(object sender, EventArgs e)
        {
            int? idOglasa = VratiIdSelektovanogOglasa();

            if (idOglasa == null)
            {
                MessageBox.Show("Izaberite oglas.");
                return;
            }

            if (string.IsNullOrEmpty(stariZahtev))
            {
                MessageBox.Show("Izaberite zahtev koji želite da izmenite.");
                return;
            }

            string noviZahtev = tbZahtev.Text.Trim();

            if (string.IsNullOrWhiteSpace(noviZahtev))
            {
                MessageBox.Show("Zahtev ne može biti prazan.");
                return;
            }

            if (noviZahtev.Length > 30)
            {
                MessageBox.Show("Zahtev može imati najviše 30 karaktera.");
                return;
            }

            try
            {
                DTOManager.IzmeniZahtev(
                    idOglasa.Value,
                    stariZahtev,
                    noviZahtev
                );

                MessageBox.Show("Zahtev je uspešno izmenjen.");

                UcitajZahteve(idOglasa.Value);

                tbZahtev.Clear();
                stariZahtev = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisiZahtev_Click(object sender, EventArgs e)
        {
            int? idOglasa = VratiIdSelektovanogOglasa();

            if (idOglasa == null)
            {
                MessageBox.Show("Izaberite oglas.");
                return;
            }

            if (string.IsNullOrEmpty(stariZahtev))
            {
                MessageBox.Show("Izaberite zahtev koji želite da obrišete.");
                return;
            }

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete zahtev?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat != DialogResult.Yes)
                return;

            try
            {
                DTOManager.ObrisiZahtev(
                    idOglasa.Value,
                    stariZahtev
                );

                MessageBox.Show("Zahtev je uspešno obrisan.");

                UcitajZahteve(idOglasa.Value);

                tbZahtev.Clear();
                stariZahtev = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
