using System;
using System.Windows.Forms;

namespace SelekcijaKandidata.Forme
{
    public partial class IzmeniOglasForma : Form
    {
        private readonly OglasPregled _oglas;

        public IzmeniOglasForma()
        {
            InitializeComponent();
        }

        public IzmeniOglasForma(OglasPregled oglas) : this()
        {
            _oglas = oglas;
            nudMaxPlata.Maximum = Decimal.MaxValue;
            nudMinPlata.Maximum = Decimal.MaxValue;
            nudMinPlata.ValueChanged += nudMinPlata_ValueChanged;
            dtpDatumObjave.ValueChanged += dtpDatumObjave_ValueChanged;
            dtpDatumObjave.MaxDate = DateTime.Today;
            dtpDatumZatvaranja.MinDate = DateTime.Today;
        }

        private void IzmeniOglasForma_Load(object sender, EventArgs e)
        {
            if (_oglas == null)
                return;

            PopuniMentore();
            cbVrstaOglasa.Items.Clear();
            cbVrstaOglasa.Items.Add(_oglas.VrstaOglasa);
            cbVrstaOglasa.SelectedIndex = 0;
            cbVrstaOglasa.Enabled = false;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            tbNazivPozicije.Text = _oglas.NazivPozicije;
            tbOpis.Text = _oglas.Opis;
            nudMinPlata.Value = _oglas.MinPlata ?? 0;
            nudMaxPlata.Value = _oglas.MaxPlata ?? 0;
            dtpDatumObjave.Value = _oglas.DatumObjave;
            dtpDatumZatvaranja.Value = _oglas.DatumZatvaranja ?? DateTime.Today;
            cbStatus.SelectedItem = _oglas.Status;

            tbProjekat.Enabled = false;
            tbPeriodAngazovanja.Enabled = false;
            tbSezona.Enabled = false;
            tbLokacija.Enabled = false;
            nudTrajanjeMeseci.Enabled = false;
            cbMentor.Enabled = false;

            switch (_oglas.VrstaOglasa)
            {
                case "privremeni rad":
                    var privremeni = DTOManager.VratiPrivremeniOglas(_oglas.Id);
                    tbProjekat.Text = privremeni.Projekat;
                    tbPeriodAngazovanja.Text = privremeni.PeriodAngazovanja;
                    tbProjekat.Enabled = true;
                    tbPeriodAngazovanja.Enabled = true;
                    break;
                case "sezonski rad":
                    var sezonski = DTOManager.VratiSezonskiOglas(_oglas.Id);
                    tbSezona.Text = sezonski.Sezona;
                    tbLokacija.Text = sezonski.Lokacija;
                    tbSezona.Enabled = true;
                    tbLokacija.Enabled = true;
                    break;
                case "praksa":
                    var praksa = DTOManager.VratiPraksu(_oglas.Id);
                    nudTrajanjeMeseci.Value = praksa.TrajanjeMeseci;
                    cbMentor.SelectedValue = praksa.IdMentora;
                    nudTrajanjeMeseci.Enabled = true;
                    cbMentor.Enabled = true;
                    break;
                case "stalni rad":
                    break;
            }
        }

        private void PopuniMentore()
        {
            try
            {
                var zaposleni = DTOManager.VratiZaposlene();
                cbMentor.DataSource = zaposleni;
                cbMentor.DisplayMember = "Zaposleni";
                cbMentor.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNazivPozicije.Text))
            {
                MessageBox.Show("Unesite naziv pozicije.");
                return;
            }

            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Izaberite status.");
                return;
            }

            try
            {
                switch (_oglas.VrstaOglasa)
                {
                    case "stalni rad":
                        DTOManager.IzmeniStalniOglas(new StalniOglasBasic
                        {
                            Id = _oglas.Id,
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
                        DTOManager.IzmeniPrivremeniOglas(new PrivremeniOglasBasic
                        {
                            Id = _oglas.Id,
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
                        DTOManager.IzmeniSezonskiOglas(new SezonskiOglasBasic
                        {
                            Id = _oglas.Id,
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
                        DTOManager.IzmeniPraksu(new PraksaBasic
                        {
                            Id = _oglas.Id,
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

                MessageBox.Show("Oglas je uspesno izmenjen.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
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
