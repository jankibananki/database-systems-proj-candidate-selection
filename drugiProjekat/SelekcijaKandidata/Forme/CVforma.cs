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
    public partial class CVforma : Form
    {
        public CVforma()
        {
            InitializeComponent();

            dgvCV.AutoGenerateColumns = false;
        }

        private void CVforma_Load(object sender, EventArgs e)
        {
            UcitajCV();
        }

        private void UcitajCV()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<CV> cvjevi = s.QueryOver<CV>()
                                    .List<CV>();

                dgvCV.DataSource = cvjevi;

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajCV_Click(object sender, EventArgs e)
        {
            DodajCVforma forma = new DodajCVforma();

            this.Hide();
            forma.Show();
        }
    }
}
