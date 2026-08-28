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

        }
    }
}
