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
    public partial class OdlukaForma : Form
    {
        public OdlukaForma()
        {
            InitializeComponent();
            dgvOdluke.AutoGenerateColumns = false;
        }

        private void OdlukaForma_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Odluka> odluke = s.QueryOver<Odluka>().List<Odluka>();

                dgvOdluke.DataSource = odluke;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
