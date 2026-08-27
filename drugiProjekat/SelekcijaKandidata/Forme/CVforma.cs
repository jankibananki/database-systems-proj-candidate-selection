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
                dgvCV.DataSource = DTOManager.VratiSveCV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void OsveziCV()
        {
            UcitajCV();
        }

        private void btnDodajCV_Click(object sender, EventArgs e)
        {
            DodajCVforma forma = new DodajCVforma(this);

            this.Hide();
            forma.Show();
        }

        private void btnIzmeniCV_Click(object sender, EventArgs e)
        {
            if (dgvCV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite CV koji želite da izmenite.");
                return;
            }

            int id = Convert.ToInt32(
                dgvCV.SelectedRows[0].Cells["colId"].Value
            );

            IzmeniCVforma forma =
                new IzmeniCVforma(this, id);

            this.Hide();
            forma.Show();
        }

        private void btnObrisiCV_Click(object sender, EventArgs e)
        {
            if (dgvCV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite CV koji želite da obrišete.");
                return;
            }

            int id = Convert.ToInt32(
                dgvCV.SelectedRows[0].Cells["colId"].Value
            );

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete CV?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat != DialogResult.Yes)
                return;

            try
            {
                DTOManager.ObrisiCV(id);
                UcitajCV();

                MessageBox.Show("CV je uspešno obrisan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
