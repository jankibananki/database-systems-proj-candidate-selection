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

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestForma forma = new TestForma();
            this.Hide();
            forma.FormClosed += (s, args) => this.Show();
            forma.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
