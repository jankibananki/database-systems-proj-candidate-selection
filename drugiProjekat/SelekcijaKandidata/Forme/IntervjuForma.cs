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
    public partial class IntervjuForma : Form
    {

        private string staraNapomena;
        public IntervjuForma()
        {
            InitializeComponent();

            dgvIntervju.AutoGenerateColumns = false;
            dgvNapomene.AutoGenerateColumns = false;
        }

        private void dgvIntervju_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIntervju.SelectedRows.Count == 0)
            {
                dgvNapomene.DataSource = null;
                return;
            }

            if (dgvIntervju.SelectedRows[0].Cells["colId"].Value == null)
                return;

            int idIntervjua = Convert.ToInt32(
                dgvIntervju.SelectedRows[0].Cells["colId"].Value
            );

            UcitajNapomene(idIntervjua);
        }

        private void UcitajNapomene(int idIntervjua)
        {
            try
            {
                dgvNapomene.DataSource =
                    DTOManager.VratiNapomeneIntervjua(idIntervjua);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IntervjuForma_Load(object sender, EventArgs e)
        {
            UcitajIntervjue();
            dgvNapomene.DataSource = null;
        }

        private void UcitajIntervjue()
        {
            try
            {
                dgvIntervju.DataSource =
                    DTOManager.VratiSveIntervjue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajIntervju_Click(object sender, EventArgs e)
        {
            DodajIntervjuForma forma = new DodajIntervjuForma(this);

            this.Hide();
            forma.Show();
        }

        private void btnIzmeniIntervju_Click(object sender, EventArgs e)
        {
            if (dgvIntervju.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite intervju koji želite da izmenite.");
                return;
            }

            int id = Convert.ToInt32(
                dgvIntervju.SelectedRows[0].Cells["colId"].Value
            );

            IzmeniIntervjuForma forma =
                new IzmeniIntervjuForma(this, id);

            this.Hide();
            forma.Show();
        }

        private void btnObrisiIntervju_Click(object sender, EventArgs e)
        {
            if (dgvIntervju.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite intervju koji želite da obrišete.");
                return;
            }

            int idIntervjua = Convert.ToInt32(
                dgvIntervju.SelectedRows[0].Cells["colId"].Value
            );

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete intervju?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat != DialogResult.Yes)
                return;

            try
            {
                DTOManager.ObrisiIntervju(idIntervjua);

                MessageBox.Show("Intervju je uspešno obrisan.");

                UcitajIntervjue();
                dgvNapomene.DataSource = null;
                tbNapomena.Clear();
                staraNapomena = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void OsveziIntervjue()
        {
            UcitajIntervjue();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            UcitajIntervjue();
        }

        private int? VratiIdSelektovanogIntervjua()
        {
            if (dgvIntervju.SelectedRows.Count == 0)
                return null;

            object vrednost = dgvIntervju.SelectedRows[0]
                                           .Cells["colId"]
                                           .Value;

            if (vrednost == null)
                return null;

            return Convert.ToInt32(vrednost);
        }

        private void dgvNapomene_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNapomene.SelectedRows.Count == 0)
            {
                tbNapomena.Clear();
                staraNapomena = null;
                return;
            }

            object vrednost = dgvNapomene.SelectedRows[0]
                                          .Cells["colNapomena"]
                                          .Value;

            staraNapomena = vrednost?.ToString();
            tbNapomena.Text = staraNapomena ?? "";
        }

        private void btnDodajNapomenu_Click(object sender, EventArgs e)
        {
            int? idIntervjua = VratiIdSelektovanogIntervjua();

            if (idIntervjua == null)
            {
                MessageBox.Show("Izaberite intervju.");
                return;
            }

            string tekst = tbNapomena.Text.Trim();

            if (string.IsNullOrWhiteSpace(tekst))
            {
                MessageBox.Show("Unesite napomenu.");
                return;
            }

            if (tekst.Length > 100)
            {
                MessageBox.Show("Napomena može imati najviše 100 karaktera.");
                return;
            }

            try
            {
                DTOManager.DodajNapomenu(
                    idIntervjua.Value,
                    tekst
                );

                MessageBox.Show("Napomena je uspešno dodata.");

                UcitajNapomene(idIntervjua.Value);

                tbNapomena.Clear();
                staraNapomena = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeniNapomenu_Click(object sender, EventArgs e)
        {
            int? idIntervjua = VratiIdSelektovanogIntervjua();

            if (idIntervjua == null)
            {
                MessageBox.Show("Izaberite intervju.");
                return;
            }

            if (string.IsNullOrEmpty(staraNapomena))
            {
                MessageBox.Show("Izaberite napomenu koju želite da izmenite.");
                return;
            }

            string novaNapomena = tbNapomena.Text.Trim();

            if (string.IsNullOrWhiteSpace(novaNapomena))
            {
                MessageBox.Show("Napomena ne može biti prazna.");
                return;
            }

            if (novaNapomena.Length > 100)
            {
                MessageBox.Show("Napomena može imati najviše 100 karaktera.");
                return;
            }

            try
            {
                DTOManager.IzmeniNapomenu(
                    idIntervjua.Value,
                    staraNapomena,
                    novaNapomena
                );

                MessageBox.Show("Napomena je uspešno izmenjena.");

                UcitajNapomene(idIntervjua.Value);

                tbNapomena.Clear();
                staraNapomena = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisiNapomenu_Click(object sender, EventArgs e)
        {
            int? idIntervjua = VratiIdSelektovanogIntervjua();

            if (idIntervjua == null)
            {
                MessageBox.Show("Izaberite intervju.");
                return;
            }

            if (string.IsNullOrEmpty(staraNapomena))
            {
                MessageBox.Show("Izaberite napomenu koju želite da obrišete.");
                return;
            }

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete napomenu?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat != DialogResult.Yes)
                return;

            try
            {
                DTOManager.ObrisiNapomenu(
                    idIntervjua.Value,
                    staraNapomena
                );

                MessageBox.Show("Napomena je uspešno obrisana.");

                UcitajNapomene(idIntervjua.Value);

                tbNapomena.Clear();
                staraNapomena = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
