using Microsoft.AspNetCore.Http;
using NHibernate;
using NHibernate.Linq;
using SelekcijaKandidata.Entiteti;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI
{
    public class DataProvider
    {
        #region Oglasi

        public static async Task<List<OglasView>> VratiSveOglaseAsync()
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                var oglasi = await s.QueryOver<Oglas>().ListAsync();
                return oglasi.Select(o => new OglasView(o)).ToList();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task<StalniOglasView?> VratiStalniOglasAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                StalniOglas? oglas = await s.GetAsync<StalniOglas>(id);
                return oglas == null ? null : new StalniOglasView(oglas);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task<PrivremeniOglasView?> VratiPrivremeniOglasAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                PrivremeniOglas? oglas = await s.GetAsync<PrivremeniOglas>(id);
                return oglas == null ? null : new PrivremeniOglasView(oglas);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task<SezonskiOglasView?> VratiSezonskiOglasAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                SezonskiOglas? oglas = await s.GetAsync<SezonskiOglas>(id);
                return oglas == null ? null : new SezonskiOglasView(oglas);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task<PraksaView?> VratiPraksuAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                Praksa? oglas = await s.GetAsync<Praksa>(id);
                return oglas == null ? null : new PraksaView(oglas);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task DodajStalniOglasAsync(StalniOglasView view)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                StalniOglas o = new()
                {
                    NazivPozicije = view.NazivPozicije ?? string.Empty,
                    VrstaOglasa = "stalni rad",
                    Opis = view.Opis ?? string.Empty,
                    MinPlata = view.MinPlata,
                    MaxPlata = view.MaxPlata,
                    DatumObjave = view.DatumObjave,
                    DatumZatvaranja = view.DatumZatvaranja,
                    Status = view.Status ?? string.Empty
                };

                await s.SaveAsync(o);
                await tx.CommitAsync();

                view.Id = o.Id;
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task DodajPrivremeniOglasAsync(PrivremeniOglasView view)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                PrivremeniOglas o = new()
                {
                    NazivPozicije = view.NazivPozicije ?? string.Empty,
                    VrstaOglasa = "privremeni rad",
                    Opis = view.Opis ?? string.Empty,
                    MinPlata = view.MinPlata,
                    MaxPlata = view.MaxPlata,
                    DatumObjave = view.DatumObjave,
                    DatumZatvaranja = view.DatumZatvaranja,
                    Status = view.Status ?? string.Empty,
                    Projekat = view.Projekat ?? string.Empty,
                    PeriodAngazovanja = view.PeriodAngazovanja ?? string.Empty
                };

                await s.SaveAsync(o);
                await tx.CommitAsync();

                view.Id = o.Id;
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task DodajSezonskiOglasAsync(SezonskiOglasView view)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                SezonskiOglas o = new()
                {
                    NazivPozicije = view.NazivPozicije ?? string.Empty,
                    VrstaOglasa = "sezonski rad",
                    Opis = view.Opis ?? string.Empty,
                    MinPlata = view.MinPlata,
                    MaxPlata = view.MaxPlata,
                    DatumObjave = view.DatumObjave,
                    DatumZatvaranja = view.DatumZatvaranja,
                    Status = view.Status ?? string.Empty,
                    Sezona = view.Sezona ?? string.Empty,
                    Lokacija = view.Lokacija ?? string.Empty
                };

                await s.SaveAsync(o);
                await tx.CommitAsync();

                view.Id = o.Id;
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task DodajPraksuAsync(PraksaView view)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                Praksa o = new()
                {
                    NazivPozicije = view.NazivPozicije ?? string.Empty,
                    VrstaOglasa = "praksa",
                    Opis = view.Opis ?? string.Empty,
                    MinPlata = view.MinPlata,
                    MaxPlata = view.MaxPlata,
                    DatumObjave = view.DatumObjave,
                    DatumZatvaranja = view.DatumZatvaranja,
                    Status = view.Status ?? string.Empty,
                    TrajanjeMeseci = view.TrajanjeMeseci,
                    Mentor = await s.LoadAsync<Zaposleni>(view.IdMentora)
                };

                await s.SaveAsync(o);
                await tx.CommitAsync();

                view.Id = o.Id;
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task ObrisiOglasAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                bool imaCV = await s.Query<CV>().AnyAsync(c => c.Oglas.Id == id);

                if (imaCV)
                    throw new Exception("Ne moze se obrisati oglas dok postoje prijavljeni kandidati.");

                var zahtevi = await s.Query<ZahtevOglas>().Where(z => z.Id.Oglas.Id == id).ToListAsync();

                foreach (var z in zahtevi)
                    await s.DeleteAsync(z);

                Oglas? oglas = await s.GetAsync<Oglas>(id);

                if (oglas != null)
                {
                    await s.DeleteAsync(oglas);
                    await tx.CommitAsync();
                }
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task IzmeniStalniOglasAsync(StalniOglasView view)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                StalniOglas o = await s.LoadAsync<StalniOglas>(view.Id);

                o.NazivPozicije = view.NazivPozicije ?? string.Empty;
                o.Opis = view.Opis ?? string.Empty;
                o.MinPlata = view.MinPlata;
                o.MaxPlata = view.MaxPlata;
                o.DatumObjave = view.DatumObjave;
                o.DatumZatvaranja = view.DatumZatvaranja;
                o.Status = view.Status ?? string.Empty;

                await s.UpdateAsync(o);
                await tx.CommitAsync();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task IzmeniPrivremeniOglasAsync(PrivremeniOglasView view)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                PrivremeniOglas o = await s.LoadAsync<PrivremeniOglas>(view.Id);

                o.NazivPozicije = view.NazivPozicije ?? string.Empty;
                o.Opis = view.Opis ?? string.Empty;
                o.MinPlata = view.MinPlata;
                o.MaxPlata = view.MaxPlata;
                o.DatumObjave = view.DatumObjave;
                o.DatumZatvaranja = view.DatumZatvaranja;
                o.Status = view.Status ?? string.Empty;
                o.Projekat = view.Projekat ?? string.Empty;
                o.PeriodAngazovanja = view.PeriodAngazovanja ?? string.Empty;

                await s.UpdateAsync(o);
                await tx.CommitAsync();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task IzmeniSezonskiOglasAsync(SezonskiOglasView view)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                SezonskiOglas o = await s.LoadAsync<SezonskiOglas>(view.Id);

                o.NazivPozicije = view.NazivPozicije ?? string.Empty;
                o.Opis = view.Opis ?? string.Empty;
                o.MinPlata = view.MinPlata;
                o.MaxPlata = view.MaxPlata;
                o.DatumObjave = view.DatumObjave;
                o.DatumZatvaranja = view.DatumZatvaranja;
                o.Status = view.Status ?? string.Empty;
                o.Sezona = view.Sezona ?? string.Empty;
                o.Lokacija = view.Lokacija ?? string.Empty;

                await s.UpdateAsync(o);
                await tx.CommitAsync();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task IzmeniPraksuAsync(PraksaView view)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                Praksa o = await s.LoadAsync<Praksa>(view.Id);

                o.NazivPozicije = view.NazivPozicije ?? string.Empty;
                o.Opis = view.Opis ?? string.Empty;
                o.MinPlata = view.MinPlata;
                o.MaxPlata = view.MaxPlata;
                o.DatumObjave = view.DatumObjave;
                o.DatumZatvaranja = view.DatumZatvaranja;
                o.Status = view.Status ?? string.Empty;
                o.TrajanjeMeseci = view.TrajanjeMeseci;
                o.Mentor = await s.LoadAsync<Zaposleni>(view.IdMentora);

                await s.UpdateAsync(o);
                await tx.CommitAsync();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        #endregion

        #region Zahtevi oglasa

        public static async Task<List<string>> VratiZahteveAsync(int idOglasa)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                return await s.Query<ZahtevOglas>()
                              .Where(z => z.Id.Oglas.Id == idOglasa)
                              .Select(z => z.Id.Zahtev)
                              .ToListAsync();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task DodajZahtevAsync(int idOglasa, string tekst)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                Oglas oglas = await s.LoadAsync<Oglas>(idOglasa);

                var id = new ZahtevOglasId
                {
                    Oglas = oglas,
                    Zahtev = tekst
                };

                if (await s.GetAsync<ZahtevOglas>(id) != null)
                    throw new Exception("Ovaj zahtev vec postoji za dati oglas.");

                await s.SaveAsync(new ZahtevOglas { Id = id });
                await tx.CommitAsync();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task ObrisiZahtevAsync(int idOglasa, string tekst)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                Oglas oglas = await s.LoadAsync<Oglas>(idOglasa);

                var id = new ZahtevOglasId
                {
                    Oglas = oglas,
                    Zahtev = tekst
                };

                ZahtevOglas zahtev = await s.LoadAsync<ZahtevOglas>(id);

                await s.DeleteAsync(zahtev);
                await tx.CommitAsync();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task PromeniZahtevAsync(int idOglasa, string stariTekst, string noviTekst)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                if (stariTekst == noviTekst)
                    return;

                using ITransaction tx = s.BeginTransaction();

                Oglas oglas = await s.LoadAsync<Oglas>(idOglasa);
                var stariId = new ZahtevOglasId
                {
                    Oglas = oglas,
                    Zahtev = stariTekst
                };

                ZahtevOglas stari = await s.LoadAsync<ZahtevOglas>(stariId);
                var noviId = new ZahtevOglasId
                {
                    Oglas = oglas,
                    Zahtev = noviTekst
                };

                if (await s.GetAsync<ZahtevOglas>(noviId) != null)
                    throw new Exception("Ovaj zahtev vec postoji za dati oglas.");

                await s.DeleteAsync(stari);
                await s.FlushAsync();
                await s.SaveAsync(new ZahtevOglas
                {
                    Id = noviId
                });
                await tx.CommitAsync();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        #endregion

        #region Odluke

        public static async Task<List<OdlukaView>> VratiSveOdlukeAsync()
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                var odluke = await s.QueryOver<Odluka>().ListAsync();
                return odluke.Select(o => new OdlukaView(o)).ToList();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task<OdlukaView?> VratiOdlukuAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                Odluka? odluka = await s.GetAsync<Odluka>(id);
                return odluka == null ? null : new OdlukaView(odluka);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        #endregion
    }
}
