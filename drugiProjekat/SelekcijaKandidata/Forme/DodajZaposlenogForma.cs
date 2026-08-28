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
            if (string.IsNullOrWhiteSpace(tbIme.Text))
            {
                MessageBox.Show("Ime je obavezno!");
                tbIme.Focus();
                return false;
            }

            if (!tbIme.Text.Trim().All(char.IsLetter))
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

            if (!tbPrezime.Text.Trim().All(char.IsLetter))
            {
                MessageBox.Show("Prezime može sadržati samo slova!");
                tbPrezime.Focus();
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


            tbIme.Focus();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
