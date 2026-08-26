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
                using (ISession s = DataLayer.GetSession())
                {
                    Intervju intervju = s.Get<Intervju>(idIntervjua);

                    if (intervju == null)
                    {
                        dgvNapomene.DataSource = null;
                        return;
                    }

                    var napomene = intervju.Napomene
                        .Select(n => new
                        {
                            Napomena = n.Id.Napomena
                        })
                        .ToList();

                    dgvNapomene.DataSource = napomene;
                }
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
                using (ISession s = DataLayer.GetSession())
                {
                    IList<Intervju> intervjui = s.QueryOver<Intervju>()
                                                 .OrderBy(x => x.Id).Asc
                                                 .List<Intervju>();

                    var prikaz = intervjui.Select(i => new
                    {
                        Id = i.Id,
                        Kandidat = i.CV.Ime + " " + i.CV.Prezime,
                        DatumIVreme = i.DatumVreme,
                        Tip = i.Tip,
                        Lokacija = i.Lokacija,
                        Zaposleni = i.Zaposleni.Ime + " " + i.Zaposleni.Prezime,
                        Ocena = i.Ocena
                    }).ToList();

                    dgvIntervju.DataSource = prikaz;
                }
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
                using (ISession s = DataLayer.GetSession())
                using (ITransaction tr = s.BeginTransaction())
                {
                    Intervju intervju = s.Get<Intervju>(idIntervjua);

                    if (intervju == null)
                        return;

                    foreach (NapomenaIntervju napomena in intervju.Napomene.ToList())
                    {
                        s.Delete(napomena);
                    }

                    s.Delete(intervju);

                    tr.Commit();
                }

                MessageBox.Show("Intervju je uspešno obrisan.");

                UcitajIntervjue();
                dgvNapomene.DataSource = null;
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

            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction tr = s.BeginTransaction())
                {
                    Intervju intervju = s.Load<Intervju>(idIntervjua.Value);

                    NapomenaIntervju napomena = new NapomenaIntervju()
                    {
                        Id = new NapomenaIntervjuId()
                        {
                            Intervju = intervju,
                            Napomena = tekst
                        }
                    };

                    s.Save(napomena);
                    tr.Commit();
                }

                UcitajNapomene(idIntervjua.Value);
                tbNapomena.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeniNapomenu_Click(object sender, EventArgs e)
        {
            int? idIntervjua = VratiIdSelektovanogIntervjua();

            if (idIntervjua == null || string.IsNullOrEmpty(staraNapomena))
            {
                MessageBox.Show("Izaberite napomenu.");
                return;
            }

            string novaNapomena = tbNapomena.Text.Trim();

            if (string.IsNullOrWhiteSpace(novaNapomena))
            {
                MessageBox.Show("Napomena ne može biti prazna.");
                return;
            }

            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction tr = s.BeginTransaction())
                {
                    Intervju intervju = s.Load<Intervju>(idIntervjua.Value);

                    NapomenaIntervjuId stariId = new NapomenaIntervjuId()
                    {
                        Intervju = intervju,
                        Napomena = staraNapomena
                    };

                    NapomenaIntervju stara = s.Get<NapomenaIntervju>(stariId);

                    if (stara == null)
                        return;

                    s.Delete(stara);
                    s.Flush();

                    NapomenaIntervju nova = new NapomenaIntervju()
                    {
                        Id = new NapomenaIntervjuId()
                        {
                            Intervju = intervju,
                            Napomena = novaNapomena
                        }
                    };

                    s.Save(nova);
                    tr.Commit();
                }

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

            if (idIntervjua == null || string.IsNullOrEmpty(staraNapomena))
            {
                MessageBox.Show("Izaberite napomenu.");
                return;
            }

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete napomenu?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat != DialogResult.Yes)
                return;

            try
            {
                using (ISession s = DataLayer.GetSession())
                using (ITransaction tr = s.BeginTransaction())
                {
                    Intervju intervju = s.Load<Intervju>(idIntervjua.Value);

                    NapomenaIntervjuId id = new NapomenaIntervjuId()
                    {
                        Intervju = intervju,
                        Napomena = staraNapomena
                    };

                    NapomenaIntervju napomena = s.Get<NapomenaIntervju>(id);

                    if (napomena != null)
                        s.Delete(napomena);

                    tr.Commit();
                }

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
