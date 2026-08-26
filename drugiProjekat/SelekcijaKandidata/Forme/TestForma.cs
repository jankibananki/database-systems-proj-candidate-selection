using NHibernate;
using NHibernate.Linq;
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
                using (ISession s = DataLayer.GetSession())
                {
                    IList<Test> testovi = s.QueryOver<Test>()
                                           .Fetch(x => x.CV).Eager
                                           .List<Test>();
                    dgvTestovi.DataSource = testovi;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajTest_Click(object sender, EventArgs e)
        {
            using (DodajTestforma forma = new DodajTestforma())
            {
                if (forma.ShowDialog() == DialogResult.OK)
                    UcitajTestove();
            }
        }

        private void btnObrisiTest_Click(object sender, EventArgs e)
        {
            Test test = dgvTestovi.CurrentRow?.DataBoundItem as Test;
            if (test == null)
                return;

            if (MessageBox.Show("Da li želite da obrišete izabrani test?", "Brisanje", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction tx = s.BeginTransaction())
                {
                    s.Delete(test);
                    tx.Commit();
                }
                UcitajTestove();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void labelTestovi_Click(object sender, EventArgs e)
        {

        }
    }
}
