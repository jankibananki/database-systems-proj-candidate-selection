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
    public partial class OglasForma : Form
    {
        public OglasForma()
        {
            InitializeComponent();
            dgvOglasi.AutoGenerateColumns = false;
        }

        private void OglasForma_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                dgvOglasi.DataSource = DTOManager.VratiSveOglase(); 
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajOglas_Click(object sender, EventArgs e)
        {
            var forma = new DodajOglasForma();
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private void btnObrisiOglas_Click(object sender, EventArgs e)
        {
            if (dgvOglasi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte oglas za brisanje.");
                return;
            }

            var izabran = (OglasPregled)dgvOglasi.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Obrisati oglas (Id={izabran.Id})?",
                "Brisanje oglasa", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                DTOManager.ObrisiOglas(izabran.Id);
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnIzmeniOglas_Click(object sender, EventArgs e)
        {
            if (dgvOglasi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte oglas za izmenu.");
                return;
            }

            var izabran = (OglasPregled)dgvOglasi.SelectedRows[0].DataBoundItem;

            var forma = new IzmeniOglasForma();
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }
    }
}
