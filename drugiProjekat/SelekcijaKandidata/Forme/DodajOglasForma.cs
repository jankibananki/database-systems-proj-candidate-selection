using System;
using System.Windows.Forms;

namespace SelekcijaKandidata.Forme
{
    public partial class DodajOglasForma : Form
    {
        public DodajOglasForma()
        {
            InitializeComponent();
            cbVrstaOglasa.SelectedIndexChanged += cbVrstaOglasa_SelectedIndexChanged;
            nudMaxPlata.Maximum = Decimal.MaxValue;
            nudMinPlata.Maximum = Decimal.MaxValue;
            nudMinPlata.ValueChanged += nudMinPlata_ValueChanged;
            dtpDatumObjave.ValueChanged += dtpDatumObjave_ValueChanged;
            dtpDatumObjave.MaxDate = DateTime.Today;
            dtpDatumZatvaranja.MinDate = DateTime.Today;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNazivPozicije.Text))
            {
                MessageBox.Show("Unesite naziv pozicije.");
                return;
            }

            if (cbVrstaOglasa.SelectedItem == null)
            {
                MessageBox.Show("Izaberite vrstu oglasa.");
                return;
            }

            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Izaberite status.");
                return;
            }

            string vrsta = cbVrstaOglasa.SelectedItem.ToString();

            try
            {
                switch (vrsta)
                {
                    case "stalni rad":
                        DTOManager.DodajStalniOglas(new StalniOglasBasic
                        {
                            NazivPozicije = tbNazivPozicije.Text.Trim(),
                            Opis = tbOpis.Text.Trim(),
                            MinPlata = nudMinPlata.Value,
                            MaxPlata = nudMaxPlata.Value,
                            DatumObjave = dtpDatumObjave.Value.Date,
                            DatumZatvaranja = dtpDatumZatvaranja.Value.Date,
                            Status = cbStatus.SelectedItem.ToString()
                        });
                        break;
                    case "privremeni rad":
                        if (string.IsNullOrWhiteSpace(tbProjekat.Text) || string.IsNullOrWhiteSpace(tbPeriodAngazovanja.Text))
                        {
                            MessageBox.Show("Unesite projekat i period angazovanja.");
                            return;
                        }
                        DTOManager.DodajPrivremeniOglas(new PrivremeniOglasBasic
                        {
                            NazivPozicije = tbNazivPozicije.Text.Trim(),
                            Opis = tbOpis.Text.Trim(),
                            MinPlata = nudMinPlata.Value,
                            MaxPlata = nudMaxPlata.Value,
                            DatumObjave = dtpDatumObjave.Value.Date,
                            DatumZatvaranja = dtpDatumZatvaranja.Value.Date,
                            Status = cbStatus.SelectedItem.ToString(),
                            Projekat = tbProjekat.Text.Trim(),
                            PeriodAngazovanja = tbPeriodAngazovanja.Text.Trim()
                        });
                        break;
                    case "sezonski rad":
                        if (string.IsNullOrWhiteSpace(tbSezona.Text) || string.IsNullOrWhiteSpace(tbLokacija.Text))
                        {
                            MessageBox.Show("Unesite sezonu i lokaciju.");
                            return;
                        }
                        DTOManager.DodajSezonskiOglas(new SezonskiOglasBasic
                        {
                            NazivPozicije = tbNazivPozicije.Text.Trim(),
                            Opis = tbOpis.Text.Trim(),
                            MinPlata = nudMinPlata.Value,
                            MaxPlata = nudMaxPlata.Value,
                            DatumObjave = dtpDatumObjave.Value.Date,
                            DatumZatvaranja = dtpDatumZatvaranja.Value.Date,
                            Status = cbStatus.SelectedItem.ToString(),
                            Sezona = tbSezona.Text.Trim(),
                            Lokacija = tbLokacija.Text.Trim()
                        });
                        break;
                    case "praksa":
                        if (cbMentor.SelectedItem == null)
                        {
                            MessageBox.Show("Izaberite mentora.");
                            return;
                        }
                        if (nudTrajanjeMeseci.Value <= 0)
                        {
                            MessageBox.Show("Trajanje prakse mora biti veće od 0 meseci.");
                            return;
                        }
                        DTOManager.DodajPraksu(new PraksaBasic
                        {
                            NazivPozicije = tbNazivPozicije.Text.Trim(),
                            Opis = tbOpis.Text.Trim(),
                            MinPlata = nudMinPlata.Value,
                            MaxPlata = nudMaxPlata.Value,
                            DatumObjave = dtpDatumObjave.Value.Date,
                            DatumZatvaranja = dtpDatumZatvaranja.Value.Date,
                            Status = cbStatus.SelectedItem.ToString(),
                            TrajanjeMeseci = (int)nudTrajanjeMeseci.Value,
                            IdMentora = ((ZaposleniLookup)cbMentor.SelectedItem).Id
                        });
                        break;
                }

                MessageBox.Show("Oglas je uspesno dodat.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private void DodajOglasForma_Load(object sender, EventArgs e)
        {
            PopuniMentor();
            AzurirajBlokiranaPolja(null);
        }

        private void PopuniMentor()
        {
            try
            {
                var zaposleni = DTOManager.VratiZaposlene();
                cbMentor.DataSource = zaposleni;
                cbMentor.DisplayMember = "Zaposleni";
                cbMentor.ValueMember = "Id";
                cbMentor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbVrstaOglasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            AzurirajBlokiranaPolja(cbVrstaOglasa.SelectedItem?.ToString());
        }

        private void AzurirajBlokiranaPolja(string vrsta)
        {
            bool privremeni = vrsta == "privremeni rad";
            bool sezonski = vrsta == "sezonski rad";
            bool praksa = vrsta == "praksa";

            tbProjekat.Enabled = privremeni;
            tbPeriodAngazovanja.Enabled = privremeni;
            if (!privremeni) 
            { 
                tbProjekat.Clear(); 
                tbPeriodAngazovanja.Clear(); 
            }

            tbSezona.Enabled = sezonski;
            tbLokacija.Enabled = sezonski;
            if (!sezonski) 
            { 
                tbSezona.Clear(); 
                tbLokacija.Clear(); 
            }

            nudTrajanjeMeseci.Enabled = praksa;
            cbMentor.Enabled = praksa;
            if (!praksa) 
            { 
                nudTrajanjeMeseci.Value = 0; 
                cbMentor.SelectedIndex = -1; 
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbNazivPozicije.Clear();
            cbVrstaOglasa.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            tbOpis.Clear();
            nudMinPlata.Value = 0;
            nudMaxPlata.Value = 0;
            dtpDatumObjave.Value = DateTime.Today;
            dtpDatumZatvaranja.Value = DateTime.Today;
            tbProjekat.Clear();
            tbPeriodAngazovanja.Clear();
            tbSezona.Clear();
            tbLokacija.Clear();
            nudTrajanjeMeseci.Value = 0;
            cbMentor.SelectedIndex = -1;
            AzurirajBlokiranaPolja(null);
        }

        private void nudMinPlata_ValueChanged(object sender, EventArgs e)
        {
            if (nudMaxPlata.Value < nudMinPlata.Value)
            {
                nudMaxPlata.Value = nudMinPlata.Value;
            }
        }

        private void dtpDatumObjave_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumZatvaranja.Value.Date < dtpDatumObjave.Value.Date)
            {
                dtpDatumZatvaranja.Value = dtpDatumObjave.Value.Date;
            }

            dtpDatumZatvaranja.MinDate = dtpDatumObjave.Value.Date;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
