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
            errorProvider1.Clear();
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

            errorProvider1.Clear();

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
            errorProvider1.Clear();
            bool validno = true;

            if (string.IsNullOrEmpty(tbIme.Text))
            {
                errorProvider1.SetError(tbIme, "Ime je obavezno!");
                validno = false;
            }
            else if (!tbIme.Text.All(c => char.IsLetter(c)))
            {
                errorProvider1.SetError(tbIme, "Ime može sadržati samo slova!");
                validno = false;
            }


            if (string.IsNullOrEmpty(tbPrezime.Text))
            {
                errorProvider1.SetError(tbPrezime, "Prezime je obavezno!");
                validno = false;
            }
            else if (!tbPrezime.Text.All(c => char.IsLetter(c)))
            {
                errorProvider1.SetError(tbPrezime, "Prezime može sadržati samo slova!");
                validno = false;
            }


            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                errorProvider1.SetError(tbEmail, "Email je obavezan!");
                validno = false;
            }
            else if (!Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(tbEmail, "Email nije u ispravnom formatu.");
                validno = false;
            }

            if (string.IsNullOrEmpty(tbBrojTelefona.Text))
            {
                errorProvider1.SetError(tbBrojTelefona, "Broj telefona je obavezan!");
                validno = false;
            }
            else if (!tbBrojTelefona.Text.All(c => char.IsDigit(c)))
            {
                errorProvider1.SetError(tbBrojTelefona, "Broj telefona može sadržati samo cifre!");
                validno = false;
            }
            else if (tbBrojTelefona.Text.Length > 10)
            {
                errorProvider1.SetError(tbBrojTelefona, "Broj telefona ne može imati više od 10 cifara!");
                validno = false;
            }

            if (cbStatus.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbStatus, "Izaberite status!");
                validno = false;
            }

            if (cbOglas.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbOglas, "Izaberite oglas!");
                validno = false;
            }

            if (dtpDatumPodnosenja.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dtpDatumPodnosenja, "Datum podnošenja ne može biti u budućnosti!");
                validno = false;
            }

            return validno;
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
