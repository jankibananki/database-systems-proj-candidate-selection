using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelekcijaKandidata.Entiteti;
using System.Text.RegularExpressions;

namespace SelekcijaKandidata.Forme
{
    public partial class DodajCVforma : Form
    {
        private CVforma prethodnaForma;
        public DodajCVforma(CVforma forma)
        {
            InitializeComponent();
            prethodnaForma = forma;
        }

        private void DodajCVforma_Load(object sender, EventArgs e)
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

            cbOglas.BeginInvoke(new Action(() =>
            {
                cbOglas.SelectedIndex = -1;
                cbOglas.SelectedItem = null;
            }));
        
        }

        private void UcitajOglase()
        {
            try
            {
                cbOglas.DataSource = DTOManager.VratiOglase();
                cbOglas.DisplayMember = "NazivPozicije";
                cbOglas.ValueMember = "Id";
                cbOglas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private bool Validacija()
        {
            if (string.IsNullOrEmpty(tbIme.Text))
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

            if (string.IsNullOrEmpty(tbPrezime.Text))
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

            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Email je obavezan!");
                tbEmail.Focus();
                return false;
            }

            if (!Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email nije u ispravnom formatu.");
                tbEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbBrojTelefona.Text))
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            try
            {
                CVBasic cv = new CVBasic
                {
                    Ime = tbIme.Text.Trim(),
                    Prezime = tbPrezime.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    DatumPodnosenja = dtpDatumPodnosenja.Value.Date,
                    Status = cbStatus.Text,
                    BrojTelefona = tbBrojTelefona.Text.Trim(),
                    IdOglasa = Convert.ToInt32(cbOglas.SelectedValue)
                };

                DTOManager.DodajCV(cv);

                MessageBox.Show("CV je uspešno dodat.");

                OcistiPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            OcistiPolja();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            prethodnaForma.OsveziCV();
            prethodnaForma.Show();
            this.Close();
        }
    }
}
