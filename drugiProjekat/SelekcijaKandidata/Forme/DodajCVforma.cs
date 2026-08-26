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
                ISession s = DataLayer.GetSession();

                IList<Oglas> oglasi = s.QueryOver<Oglas>()
                                       .OrderBy(x => x.Id).Asc
                                       .List<Oglas>();

                cbOglas.DisplayMember = "NazivPozicije";
                cbOglas.ValueMember = "Id";
                cbOglas.DataSource = oglasi;

                s.Close();
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

            if(string.IsNullOrEmpty(tbIme.Text))
            {
                errorProvider1.SetError(tbIme, "Ime je obavezno!");
                validno = false;
            }
            else if (!tbIme.Text.All(c=>char.IsLetter(c)))
            {
                errorProvider1.SetError(tbIme, "Ime može sadržati samo slova!");
                validno = false;
            }


            if (string.IsNullOrEmpty(tbPrezime.Text))
            {
                errorProvider1.SetError(tbPrezime, "Prezime je obavezno!");
                validno = false;
            }
            else if(!tbPrezime.Text.All(c=>char.IsLetter(c)))
            {
                errorProvider1.SetError(tbPrezime, "Prezime može sadržati samo slova!");
                validno=false;
            }


            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                errorProvider1.SetError(tbEmail, "Email je obavezan!");
                validno = false;
            }
            else if(!Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(tbEmail, "Email nije u ispravnom formatu.");
                validno = false;
            }

            if(string.IsNullOrEmpty(tbBrojTelefona.Text))
            {
                errorProvider1.SetError(tbBrojTelefona, "Broj telefona je obavezan!");
                validno = false;
            }
            else if(!tbBrojTelefona.Text.All(c=>char.IsDigit(c)))
            {
                errorProvider1.SetError(tbBrojTelefona, "Broj telefona može sadržati samo cifre!");
                validno = false;
            }
            else if(tbBrojTelefona.Text.Length>10)
            {
                errorProvider1.SetError(tbBrojTelefona, "Broj telefona ne može imati više od 10 cifara!");
                validno=false;
            }

            if (cbStatus.SelectedIndex==-1)
            {
                errorProvider1.SetError(cbStatus, "Izaberite status!");
                validno=false;
            }

            if (cbOglas.SelectedIndex==-1)
            {
                errorProvider1.SetError(cbOglas, "Izaberite oglas!");
                validno=false;
            }

            if(dtpDatumPodnosenja.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dtpDatumPodnosenja, "Datum podnošenja ne može biti u budućnosti!");
                validno=false;
            }

                return validno;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
            { return; }

            try
            {
                ISession s = DataLayer.GetSession();

                Oglas izabraniOglas = (Oglas)cbOglas.SelectedItem;

                CV noviCV = new CV()
                {
                    Ime = tbIme.Text.Trim(),
                    Prezime = tbPrezime.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    DatumPodnosenja = dtpDatumPodnosenja.Value.Date,
                    Status=cbStatus.SelectedItem.ToString(),
                    BrojTelefona=tbBrojTelefona.Text.Trim(),
                    Oglas=izabraniOglas
                };

                s.Save(noviCV);
                s.Flush();
                s.Close();

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

            errorProvider1.Clear();

            tbIme.Focus();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            OcistiPolja();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            prethodnaForma.Show();
            this.Close();
        }
    }
}
