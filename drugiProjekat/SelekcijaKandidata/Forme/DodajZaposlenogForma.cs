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
    public partial class DodajZaposlenogForma : Form
    {
        public DodajZaposlenogForma()
        {
            InitializeComponent();
        }

        private bool Validacija()
        {
            errorProvider1.Clear();
            bool validno = true;

            if (string.IsNullOrWhiteSpace(tbIme.Text))
            {
                errorProvider1.SetError(
                    tbIme,
                    "Ime je obavezno!"
                );

                validno = false;
            }
            else if (!tbIme.Text.Trim().All(char.IsLetter))
            {
                errorProvider1.SetError(
                    tbIme,
                    "Ime može sadržati samo slova!"
                );

                validno = false;
            }

            if (string.IsNullOrWhiteSpace(tbPrezime.Text))
            {
                errorProvider1.SetError(
                    tbPrezime,
                    "Prezime je obavezno!"
                );

                validno = false;
            }
            else if (!tbPrezime.Text.Trim().All(char.IsLetter))
            {
                errorProvider1.SetError(
                    tbPrezime,
                    "Prezime može sadržati samo slova!"
                );

                validno = false;
            }

            return validno;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            try
            {
                ZaposleniBasic zaposleni =
                    new ZaposleniBasic
                    {
                        Ime = tbIme.Text.Trim(),
                        Prezime = tbPrezime.Text.Trim()
                    };

                DTOManager.DodajZaposlenog(zaposleni);

                MessageBox.Show(
                    "Zaposleni je uspešno dodat."
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbIme.Clear();
            tbPrezime.Clear();

            errorProvider1.Clear();

            tbIme.Focus();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
