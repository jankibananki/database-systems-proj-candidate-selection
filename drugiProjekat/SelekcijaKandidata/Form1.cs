using SelekcijaKandidata.Forme;
using System;
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
            this.Hide();
            CVforma forma = new CVforma();
            forma.ShowDialog();
            this.Show();
        }

        private void btnOglas_Click(object sender, EventArgs e)
        {
            this.Hide();
            OglasForma forma = new OglasForma();
            forma.ShowDialog();
            this.Show();
        }

        private void btnOdluka_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdlukaForma forma = new OdlukaForma();
            forma.ShowDialog();
            this.Show();
        }
        
        private void btnIntervju_Click(object sender, EventArgs e)
        {
            this.Hide();
            IntervjuForma forma = new IntervjuForma();
            forma.ShowDialog();
            this.Show();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZaposleniForma forma = new ZaposleniForma();
            forma.ShowDialog();
            this.Show();
        }
    }
}
