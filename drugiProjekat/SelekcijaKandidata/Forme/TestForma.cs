using NHibernate;
using NHibernate.Linq;
using SelekcijaKandidata.Entiteti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SelekcijaKandidata.Forme
{
    public partial class TestForma : Form
    {
        public TestForma()
        {
            InitializeComponent();
            dgvTestovi.AutoGenerateColumns = false;
        }

        private void TestForma_Load(object sender, EventArgs e)
        {
            UcitajTestove();
        }

        private void UcitajTestove()
        {
            try
            {
                dgvTestovi.DataSource = DTOManager.VratiSveTestove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            var forma = new DodajTestforma();
            forma.ShowDialog();
            this.Show();
            UcitajTestove();
        }

        private void btnObrisiTest_Click(object sender, EventArgs e)
        {
            if (dgvTestovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte test za brisanje.");
                return;
            }

            var izabran = (TestPregled)dgvTestovi.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Obrisati test (Id={izabran.Id})?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                DTOManager.ObrisiTest(izabran.Id);
                UcitajTestove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private void btnIzmeniTest_Click(object sender, EventArgs e)
        {
            if (dgvTestovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte test za izmenu.");
                return;
            }

            var izabran = (TestPregled)dgvTestovi.SelectedRows[0].DataBoundItem;

            this.Hide();

            var forma = new IzmeniTestForma(izabran);
            forma.ShowDialog();

            this.Show();
            UcitajTestove();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
