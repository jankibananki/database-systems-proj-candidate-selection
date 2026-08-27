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
    public partial class DodajIntervjuForma : Form
    {
        private IntervjuForma prethodnaForma;
        public DodajIntervjuForma(IntervjuForma forma)
        {
            InitializeComponent();
            prethodnaForma = forma;
        }

        private void DodajIntervjuForma_Load(object sender, EventArgs e)
        {
            cbTip.Items.AddRange(new object[]
            {
                    "licni",
                    "video",
                    "telefonski"
            });

            cbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKandidat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbZaposleni.DropDownStyle = ComboBoxStyle.DropDownList;

            UcitajKandidate();
            UcitajZaposlene();

            cbKandidat.SelectedIndex = -1;
            cbZaposleni.SelectedIndex = -1;
            cbTip.SelectedIndex = -1;
        }

        private void UcitajKandidate()
        {
            try
            {
                cbKandidat.DataSource = DTOManager.VratiKandidate();
                cbKandidat.DisplayMember = "Kandidat";
                cbKandidat.ValueMember = "Id";
                cbKandidat.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajZaposlene()
        {
            try
            {
                cbZaposleni.DataSource = DTOManager.VratiZaposlene();
                cbZaposleni.DisplayMember = "Zaposleni";
                cbZaposleni.ValueMember = "Id";
                cbZaposleni.SelectedIndex = -1;
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

            if (cbKandidat.SelectedIndex == -1)
            {
                errorProvider1.SetError(
                    cbKandidat,
                    "Izaberite kandidata!"
                );

                validno = false;
            }

            if (cbTip.SelectedIndex == -1)
            {
                errorProvider1.SetError(
                    cbTip,
                    "Izaberite tip intervjua!"
                );

                validno = false;
            }

            if (string.IsNullOrWhiteSpace(tbLokacija.Text))
            {
                errorProvider1.SetError(
                    tbLokacija,
                    "Lokacija je obavezna!"
                );

                validno = false;
            }

            if (cbZaposleni.SelectedIndex == -1)
            {
                errorProvider1.SetError(
                    cbZaposleni,
                    "Izaberite zaposlenog!"
                );

                validno = false;
            }

            if (!string.IsNullOrWhiteSpace(tbOcena.Text))
            {
                int ocena;

                if (!int.TryParse(tbOcena.Text, out ocena))
                {
                    errorProvider1.SetError(
                        tbOcena,
                        "Ocena mora biti broj!"
                    );

                    validno = false;
                }
                else if (ocena < 1 || ocena > 100)
                {
                    errorProvider1.SetError(
                        tbOcena,
                        "Ocena mora biti između 1 i 100!"
                        //doduse u bazu nismo stavili nikakav check moz da ide dokle oce nez jel bitno da se ogranici i tamo
                    );

                    validno = false;
                }
            }

            if (dtpDatumIVreme.Value > DateTime.Now)
            {
                errorProvider1.SetError(
                    dtpDatumIVreme,
                    "Intervju ne može biti u budućnosti!"
                );

                validno = false;
            }

            return validno;
        }

        private void btnDodajIntervju_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            try
            {
                IntervjuBasic intervju = new IntervjuBasic
                {
                    IdCV = Convert.ToInt32(cbKandidat.SelectedValue),
                    DatumVreme = dtpDatumIVreme.Value,
                    Tip = cbTip.SelectedItem.ToString(),
                    Lokacija = tbLokacija.Text.Trim(),
                    IdZaposlenog = Convert.ToInt32(cbZaposleni.SelectedValue),
                    Ocena = string.IsNullOrWhiteSpace(tbOcena.Text)
                        ? (int?)null
                        : int.Parse(tbOcena.Text)
                };

                DTOManager.DodajIntervju(intervju);

                MessageBox.Show("Intervju je uspešno dodat.");

                OcistiPolja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OcistiPolja()
        {
            cbKandidat.SelectedIndex = -1;
            cbTip.SelectedIndex = -1;
            cbZaposleni.SelectedIndex = -1;

            tbLokacija.Clear();
            tbOcena.Clear();

            dtpDatumIVreme.Value = DateTime.Now;

            errorProvider1.Clear();
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
