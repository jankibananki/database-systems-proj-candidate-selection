using SelekcijaKandidata.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelekcijaKandidata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            CVforma forma = new CVforma();

            this.Hide();
            forma.Show();
        }

        private void btnIntervju_Click(object sender, EventArgs e)
        {
            IntervjuForma forma = new IntervjuForma();

            this.Hide();
            forma.Show();
        }
    }
}
