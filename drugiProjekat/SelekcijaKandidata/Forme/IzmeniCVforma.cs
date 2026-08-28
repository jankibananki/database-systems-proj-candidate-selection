using NHibernate;
using SelekcijaKandidata.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelekcijaKandidata.Forme
{
    public partial class IzmeniCVforma : Form
    {
        private CVforma prethodnaForma;
        private int cvId;
        public IzmeniCVforma(CVforma forma, int id)
        {
            prethodnaForma = forma;
            cvId = id;
            InitializeComponent();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            try
            {
                CVBasic cv = new CVBasic
                {
                    Id = cvId,
                    Ime = tbIme.Text.Trim(),
                    Prezime = tbPrezime.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    DatumPodnosenja = dtpDatumPodnosenja.Value.Date,
                    Status = cbStatus.Text,
                    BrojTelefona = tbBrojTelefona.Text.Trim(),
                    IdOglasa = Convert.ToInt32(cbOglas.SelectedValue)
                };

                DTOManager.IzmeniCV(cv);

                MessageBox.Show("CV je uspešno izmenjen.");

                prethodnaForma.OsveziCV();
                prethodnaForma.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            prethodnaForma.Show();
            this.Close();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            UcitajPodatkeCV();
        }

        private void OcistiPolja()
        {
            tbIme.Clear();
            tbPrezime.Clear();
            tbEmail.Clear();
            tbBrojTelefona.Clear();

            cbStatus.SelectedIndex = -1;
            cbOglas.SelectedIndex = -1;

            dtpDatumPodnosenja.Value = DateTime.Today;

            tbIme.Focus();
        }

        private void IzmeniCVforma_Load(object sender, EventArgs e)
        {
            cbStatus.Items.AddRange(new object[]
            {
                    "primljen",
                    "u procesu",
                    "odbijen",
                    "pozvan na intervju"
            });

            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOglas.DropDownStyle = ComboBoxStyle.DropDownList;

            UcitajOglase();
            UcitajPodatkeCV();
        }

        private void UcitajOglase()
        {
            try
            {
                cbOglas.DataSource = DTOManager.VratiOglase();
                cbOglas.DisplayMember = "NazivPozicije";
                cbOglas.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Validacija()
        {
            if (string.IsNullOrWhiteSpace(tbIme.Text))
            {
                MessageBox.Show("Ime je obavezno!");
                tbIme.Focus();
                return false;
            }

            if (!tbIme.Text.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("Ime može sadržati samo slova!");
                tbIme.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPrezime.Text))
            {
                MessageBox.Show("Prezime je obavezno!");
                tbPrezime.Focus();
                return false;
            }

            if (!tbPrezime.Text.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("Prezime može sadržati samo slova!");
                tbPrezime.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Email je obavezan!");
                tbEmail.Focus();
                return false;
            }

            if (!Regex.IsMatch(
                tbEmail.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email nije u ispravnom formatu.");
                tbEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbBrojTelefona.Text))
            {
                MessageBox.Show("Broj telefona je obavezan!");
                tbBrojTelefona.Focus();
                return false;
            }

            if (!tbBrojTelefona.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Broj telefona može sadržati samo cifre!");
                tbBrojTelefona.Focus();
                return false;
            }

            if (tbBrojTelefona.Text.Length > 10)
            {
                MessageBox.Show("Broj telefona ne može imati više od 10 cifara!");
                tbBrojTelefona.Focus();
                return false;
            }

            if (cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite status!");
                cbStatus.Focus();
                return false;
            }

            if (cbOglas.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite oglas!");
                cbOglas.Focus();
                return false;
            }

            if (dtpDatumPodnosenja.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Datum podnošenja ne može biti u budućnosti!");
                dtpDatumPodnosenja.Focus();
                return false;
            }

            return true;
        }

        private void UcitajPodatkeCV()
        {
            try
            {
                CVBasic cv = DTOManager.VratiCV(cvId);

                if (cv == null)
                {
                    MessageBox.Show("CV nije pronađen.");
                    return;
                }

                tbIme.Text = cv.Ime;
                tbPrezime.Text = cv.Prezime;
                tbEmail.Text = cv.Email;
                tbBrojTelefona.Text = cv.BrojTelefona;

                dtpDatumPodnosenja.Value = cv.DatumPodnosenja;
                cbStatus.SelectedItem = cv.Status;
                cbOglas.SelectedValue = cv.IdOglasa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
