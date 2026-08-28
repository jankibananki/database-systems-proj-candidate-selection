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
    public partial class IzmeniIntervjuForma : Form
    {
        private IntervjuForma prethodnaForma;
        private int intervjuId;
        public IzmeniIntervjuForma(IntervjuForma forma, int id)
        {
            InitializeComponent();

            prethodnaForma = forma;
            intervjuId = id;
        }

        private void IzmeniIntervjuForma_Load(object sender, EventArgs e)
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
            UcitajPodatkeIntervjua();
        }

        private void UcitajKandidate()
        {
            try
            {
                cbKandidat.DataSource = DTOManager.VratiKandidate();
                cbKandidat.DisplayMember = "Kandidat";
                cbKandidat.ValueMember = "Id";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajPodatkeIntervjua()
        {
            try
            {
                IntervjuBasic intervju =
                    DTOManager.VratiIntervju(intervjuId);

                if (intervju == null)
                {
                    MessageBox.Show("Intervju nije pronađen.");
                    return;
                }

                cbKandidat.SelectedValue = intervju.IdCV;
                dtpDatumIVreme.Value = intervju.DatumVreme;
                cbTip.SelectedItem = intervju.Tip;
                tbLokacija.Text = intervju.Lokacija;
                cbZaposleni.SelectedValue = intervju.IdZaposlenog;

                if (intervju.Ocena.HasValue)
                    tbOcena.Text = intervju.Ocena.Value.ToString();
                else
                    tbOcena.Clear();
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

                if (ocena < 1 || ocena > 10)
                {
                    MessageBox.Show("Ocena mora biti između 1 i 10!");
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

        private void btnIzmeniIntervju_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            try
            {
                IntervjuBasic intervju = new IntervjuBasic
                {
                    Id = intervjuId,
                    IdCV = Convert.ToInt32(cbKandidat.SelectedValue),
                    DatumVreme = dtpDatumIVreme.Value,
                    Tip = cbTip.SelectedItem.ToString(),
                    Lokacija = tbLokacija.Text.Trim(),
                    IdZaposlenog = Convert.ToInt32(cbZaposleni.SelectedValue),
                    Ocena = string.IsNullOrWhiteSpace(tbOcena.Text)
                        ? (int?)null
                        : int.Parse(tbOcena.Text)
                };

                DTOManager.IzmeniIntervju(intervju);

                MessageBox.Show("Intervju je uspešno izmenjen.");

                prethodnaForma.OsveziIntervjue();
                prethodnaForma.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            UcitajPodatkeIntervjua();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            prethodnaForma.Show();
            this.Close();
        }
    }
}
