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
    public partial class IzmeniZaposlenogForma : Form
    {
        private int zaposleniId;
        public IzmeniZaposlenogForma(int id)
        {
            InitializeComponent();
            zaposleniId = id;
        }

        private void IzmeniZaposlenogForma_Load(object sender, EventArgs e)
        {
            UcitajPodatkeZaposlenog();
        }

        private void UcitajPodatkeZaposlenog()
        {
            try
            {
                ZaposleniBasic zaposleni =
                    DTOManager.VratiZaposlenog(zaposleniId);

                if (zaposleni == null)
                {
                    MessageBox.Show("Zaposleni nije pronađen.");
                    this.Close();
                    return;
                }

                tbIme.Text = zaposleni.Ime;
                tbPrezime.Text = zaposleni.Prezime;
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

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            try
            {
                ZaposleniBasic zaposleni =
                    new ZaposleniBasic
                    {
                        Id = zaposleniId,
                        Ime = tbIme.Text.Trim(),
                        Prezime = tbPrezime.Text.Trim()
                    };

                DTOManager.IzmeniZaposlenog(zaposleni);

                MessageBox.Show(
                    "Zaposleni je uspešno izmenjen."
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
            UcitajPodatkeZaposlenog();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
