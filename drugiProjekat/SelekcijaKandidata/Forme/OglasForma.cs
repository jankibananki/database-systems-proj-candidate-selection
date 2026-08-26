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
                ISession s = DataLayer.GetSession();

                IList<Oglas> oglasi = s.QueryOver<Oglas>().List<Oglas>();

                dgvOglasi.DataSource = oglasi;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
