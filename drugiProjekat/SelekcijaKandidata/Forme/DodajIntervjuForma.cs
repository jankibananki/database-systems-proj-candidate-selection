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
            if (cbKandidat.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite kandidata!");
                cbKandidat.Focus();
                return false;
            }

            if (cbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite tip intervjua!");
                cbTip.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbLokacija.Text))
            {
                MessageBox.Show("Lokacija je obavezna!");
                tbLokacija.Focus();
                return false;
            }

            if (cbZaposleni.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite zaposlenog!");
                cbZaposleni.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(tbOcena.Text))
            {
                int ocena;

                if (!int.TryParse(tbOcena.Text, out ocena))
                {
                    MessageBox.Show("Ocena mora biti broj!");
                    tbOcena.Focus();
                    return false;
                }

                if (ocena < 1 || ocena > 100)
                {
                    MessageBox.Show("Ocena mora biti između 1 i 100!");
                    tbOcena.Focus();
                    return false;
                }
            }

            if (dtpDatumIVreme.Value > DateTime.Now)
            {
                MessageBox.Show("Intervju ne može biti u budućnosti!");
                dtpDatumIVreme.Focus();
                return false;
            }

            return true;
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
