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
                using (ISession s = DataLayer.GetSession())
                {
                    IList<CV> kandidati = s.QueryOver<CV>()
                                           .OrderBy(x => x.Id).Asc
                                           .List<CV>();

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
                using (ISession s = DataLayer.GetSession())
                using (ITransaction tr = s.BeginTransaction())
                {
                    CV kandidat = (CV)cbKandidat.SelectedItem;
                    Zaposleni zaposleni = (Zaposleni)cbZaposleni.SelectedItem;

                    Intervju intervju = new Intervju()
                    {
                        Tip = cbTip.SelectedItem.ToString(),
                        DatumVreme = dtpDatumIVreme.Value,
                        Lokacija = tbLokacija.Text.Trim(),
                        CV = s.Get<CV>(kandidat.Id),
                        Zaposleni = s.Get<Zaposleni>(zaposleni.Id)
                    };

                    if (string.IsNullOrWhiteSpace(tbOcena.Text))
                        intervju.Ocena = null;
                    else
                        intervju.Ocena = int.Parse(tbOcena.Text);

                    s.Save(intervju);

                    tr.Commit();
                }

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
