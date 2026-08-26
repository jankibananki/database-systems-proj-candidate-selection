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
                using (ISession s = DataLayer.GetSession())
                {
                    IList<CV> kandidati = s.QueryOver<CV>()
                                           .OrderBy(x => x.Id).Asc
                                           .List<CV>();

                    cbKandidat.ValueMember = "Id";
                    cbKandidat.DataSource = kandidati;

                    cbKandidat.Format += (sender, e) =>
                    {
                        CV cv = e.ListItem as CV;

                        if (cv != null)
                            e.Value = cv.Ime + " " + cv.Prezime;
                    };
                }
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
                using (ISession s = DataLayer.GetSession())
                {
                    IList<Zaposleni> zaposleni = s.QueryOver<Zaposleni>()
                                                  .OrderBy(x => x.Id).Asc
                                                  .List<Zaposleni>();

                    cbZaposleni.ValueMember = "Id";
                    cbZaposleni.DataSource = zaposleni;

                    cbZaposleni.Format += (sender, e) =>
                    {
                        Zaposleni z = e.ListItem as Zaposleni;

                        if (z != null)
                            e.Value = z.Ime + " " + z.Prezime;
                    };
                }
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
                using (ISession s = DataLayer.GetSession())
                {
                    Intervju intervju = s.Get<Intervju>(intervjuId);

                    if (intervju == null)
                    {
                        MessageBox.Show("Intervju nije pronađen.");
                        return;
                    }

                    dtpDatumIVreme.Value = intervju.DatumVreme;
                    cbTip.SelectedItem = intervju.Tip;
                    tbLokacija.Text = intervju.Lokacija;

                    if (intervju.Ocena.HasValue)
                        tbOcena.Text = intervju.Ocena.Value.ToString();
                    else
                        tbOcena.Clear();

                    cbKandidat.SelectedValue = intervju.CV.Id;
                    cbZaposleni.SelectedValue = intervju.Zaposleni.Id;
                }
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
                errorProvider1.SetError(cbKandidat, "Izaberite kandidata!");
                validno = false;
            }

            if (cbTip.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbTip, "Izaberite tip intervjua!");
                validno = false;
            }

            if (string.IsNullOrWhiteSpace(tbLokacija.Text))
            {
                errorProvider1.SetError(tbLokacija, "Lokacija je obavezna!");
                validno = false;
            }

            if (cbZaposleni.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbZaposleni, "Izaberite zaposlenog!");
                validno = false;
            }

            if (!string.IsNullOrWhiteSpace(tbOcena.Text))
            {
                int ocena;

                if (!int.TryParse(tbOcena.Text, out ocena))
                {
                    errorProvider1.SetError(tbOcena, "Ocena mora biti broj!");
                    validno = false;
                }
                else if (ocena < 1 || ocena > 10)
                {
                    errorProvider1.SetError(tbOcena, "Ocena mora biti između 1 i 10!");
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

        private void btnIzmeniIntervju_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction tr = s.BeginTransaction())
                {
                    Intervju intervju = s.Get<Intervju>(intervjuId);

                    if (intervju == null)
                    {
                        MessageBox.Show("Intervju nije pronađen.");
                        return;
                    }

                    int idCV = Convert.ToInt32(cbKandidat.SelectedValue);
                    int idZaposlenog = Convert.ToInt32(cbZaposleni.SelectedValue);

                    intervju.CV = s.Get<CV>(idCV);
                    intervju.Zaposleni = s.Get<Zaposleni>(idZaposlenog);

                    intervju.DatumVreme = dtpDatumIVreme.Value;
                    intervju.Tip = cbTip.SelectedItem.ToString();
                    intervju.Lokacija = tbLokacija.Text.Trim();

                    if (string.IsNullOrWhiteSpace(tbOcena.Text))
                        intervju.Ocena = null;
                    else
                        intervju.Ocena = int.Parse(tbOcena.Text);

                    tr.Commit();
                }

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
            errorProvider1.Clear();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            prethodnaForma.Show();
            this.Close();
        }
    }
}
