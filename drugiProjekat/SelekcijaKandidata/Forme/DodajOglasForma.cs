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
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

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
    }
}
