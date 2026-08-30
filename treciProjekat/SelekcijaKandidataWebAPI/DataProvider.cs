using NHibernate;
using SelekcijaKandidata.Entiteti;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI
{
    public class DataProvider
    {
        #region CV

        public static List<CVView> VratiSveCV()
        {
            using (NHibernate.ISession session = DataLayer.GetSession())
            {
                IList<CV> cvjevi = session.QueryOver<CV>().List();

                return cvjevi.Select(cv => new CVView
                {
                    Id = cv.Id,
                    Ime = cv.Ime,
                    Prezime = cv.Prezime,
                    Email = cv.Email,
                    DatumPodnosenja = cv.DatumPodnosenja,
                    Status = cv.Status,
                    BrojTelefona = cv.BrojTelefona,
                    IdOglasa = cv.Oglas.Id
                }).ToList();
            }
        }

        public static CVView VratiCV(int id)
        {
            using (NHibernate.ISession session = DataLayer.GetSession())
            {
                CV cv = session.Get<CV>(id);

                if (cv == null)
                    return null;

                return new CVView
                {
                    Id = cv.Id,
                    Ime = cv.Ime,
                    Prezime = cv.Prezime,
                    Email = cv.Email,
                    DatumPodnosenja = cv.DatumPodnosenja,
                    Status = cv.Status,
                    BrojTelefona = cv.BrojTelefona,
                    IdOglasa = cv.Oglas.Id
                };
            }
        }

        public static int DodajCV(CVView dto)
        {
            using (NHibernate.ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    Oglas oglas = session.Get<Oglas>(dto.IdOglasa);

                    if (oglas == null)
                        throw new Exception("Oglas nije pronađen.");

                    CV cv = new CV
                    {
                        Ime = dto.Ime,
                        Prezime = dto.Prezime,
                        Email = dto.Email,
                        DatumPodnosenja = dto.DatumPodnosenja,
                        Status = dto.Status,
                        BrojTelefona = dto.BrojTelefona,
                        Oglas = oglas
                    };

                    session.Save(cv);

                    transaction.Commit();

                    return cv.Id;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }

        public static bool IzmeniCV(int id, CVView dto)
        {
            using (NHibernate.ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    CV cv = session.Get<CV>(id);

                    if (cv == null)
                        return false;

                    Oglas oglas = session.Get<Oglas>(dto.IdOglasa);

                    if (oglas == null)
                        throw new Exception("Oglas nije pronađen.");

                    cv.Ime = dto.Ime;
                    cv.Prezime = dto.Prezime;
                    cv.Email = dto.Email;
                    cv.DatumPodnosenja = dto.DatumPodnosenja;
                    cv.Status = dto.Status;
                    cv.BrojTelefona = dto.BrojTelefona;
                    cv.Oglas = oglas;

                    session.Update(cv);

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }

        public static bool ObrisiCV(int id)
        {
            using (NHibernate.ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    CV cv = session.Get<CV>(id);

                    if (cv == null)
                        return false;

                    session.Delete(cv);

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }

        #endregion

        #region Intervju

        public static List<IntervjuView> VratiSveIntervjue()
        {
            using (var session = DataLayer.GetSession())
            {
                IList<Intervju> intervjui =
                    session.QueryOver<Intervju>().List();

                return intervjui.Select(i => new IntervjuView
                {
                    Id = i.Id,
                    Tip = i.Tip,
                    DatumVreme = i.DatumVreme,
                    Lokacija = i.Lokacija,
                    Ocena = i.Ocena,
                    IdCV = i.CV.Id,
                    IdZaposlenog = i.Zaposleni.Id
                }).ToList();
            }
        }

        public static IntervjuView VratiIntervju(int id)
        {
            using (var session = DataLayer.GetSession())
            {
                Intervju intervju = session.Get<Intervju>(id);

                if (intervju == null)
                    return null;

                return new IntervjuView
                {
                    Id = intervju.Id,
                    Tip = intervju.Tip,
                    DatumVreme = intervju.DatumVreme,
                    Lokacija = intervju.Lokacija,
                    Ocena = intervju.Ocena,
                    IdCV = intervju.CV.Id,
                    IdZaposlenog = intervju.Zaposleni.Id
                };
            }
        }

        public static int DodajIntervju(IntervjuView dto)
        {
            using (var session = DataLayer.GetSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    CV cv = session.Get<CV>(dto.IdCV);

                    if (cv == null)
                        throw new Exception("CV nije pronađen.");

                    Zaposleni zaposleni =
                        session.Get<Zaposleni>(dto.IdZaposlenog);

                    if (zaposleni == null)
                        throw new Exception("Zaposleni nije pronađen.");

                    Intervju intervju = new Intervju
                    {
                        Tip = dto.Tip,
                        DatumVreme = dto.DatumVreme,
                        Lokacija = dto.Lokacija,
                        Ocena = dto.Ocena,
                        CV = cv,
                        Zaposleni = zaposleni
                    };

                    session.Save(intervju);

                    transaction.Commit();

                    return intervju.Id;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }

        public static bool IzmeniIntervju(int id, IntervjuView dto)
        {
            using (var session = DataLayer.GetSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    Intervju intervju =
                        session.Get<Intervju>(id);

                    if (intervju == null)
                        return false;

                    CV cv = session.Get<CV>(dto.IdCV);

                    if (cv == null)
                        throw new Exception("CV nije pronađen.");

                    Zaposleni zaposleni =
                        session.Get<Zaposleni>(dto.IdZaposlenog);

                    if (zaposleni == null)
                        throw new Exception("Zaposleni nije pronađen.");

                    intervju.Tip = dto.Tip;
                    intervju.DatumVreme = dto.DatumVreme;
                    intervju.Lokacija = dto.Lokacija;
                    intervju.Ocena = dto.Ocena;
                    intervju.CV = cv;
                    intervju.Zaposleni = zaposleni;

                    session.Update(intervju);

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }
        public static bool ObrisiIntervju(int id)
        {
            using (var session = DataLayer.GetSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    Intervju intervju =
                        session.Get<Intervju>(id);

                    if (intervju == null)
                        return false;

                    session.Delete(intervju);

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }

        #endregion

        #region NapomenaIntervju

        public static List<NapomenaIntervjuView> VratiNapomeneIntervjua(int idIntervjua)
        {
            using (var session = DataLayer.GetSession())
            {
                Intervju intervju = session.Get<Intervju>(idIntervjua);

                if (intervju == null)
                    return new List<NapomenaIntervjuView>();

                return intervju.Napomene
                    .Select(n => new NapomenaIntervjuView
                    {
                        IdIntervjua = intervju.Id,
                        Napomena = n.Id.Napomena
                    })
                    .ToList();
            }
        }
        public static bool DodajNapomenu(NapomenaIntervjuView dto)
        {
            using (var session = DataLayer.GetSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    Intervju intervju =
                        session.Get<Intervju>(dto.IdIntervjua);

                    if (intervju == null)
                        return false;

                    NapomenaIntervjuId id = new NapomenaIntervjuId
                    {
                        Intervju = intervju,
                        Napomena = dto.Napomena
                    };

                    NapomenaIntervju postojeca =
                        session.Get<NapomenaIntervju>(id);

                    if (postojeca != null)
                        throw new Exception("Ova napomena već postoji.");

                    NapomenaIntervju napomena =
                        new NapomenaIntervju
                        {
                            Id = id
                        };

                    session.Save(napomena);

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }

        public static bool ObrisiNapomenu(
    int idIntervjua,
    string tekst)
        {
            using (var session = DataLayer.GetSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    Intervju intervju =
                        session.Get<Intervju>(idIntervjua);

                    if (intervju == null)
                        return false;

                    NapomenaIntervjuId id =
                        new NapomenaIntervjuId
                        {
                            Intervju = intervju,
                            Napomena = tekst
                        };

                    NapomenaIntervju napomena =
                        session.Get<NapomenaIntervju>(id);

                    if (napomena == null)
                        return false;

                    session.Delete(napomena);

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }

        public static bool IzmeniNapomenu(
    int idIntervjua,
    string staraNapomena,
    string novaNapomena)
        {
            using (var session = DataLayer.GetSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    Intervju intervju =
                        session.Get<Intervju>(idIntervjua);

                    if (intervju == null)
                        return false;

                    NapomenaIntervjuId stariId =
                        new NapomenaIntervjuId
                        {
                            Intervju = intervju,
                            Napomena = staraNapomena
                        };

                    NapomenaIntervju stara =
                        session.Get<NapomenaIntervju>(stariId);

                    if (stara == null)
                        return false;

                    if (staraNapomena == novaNapomena)
                        return true;

                    NapomenaIntervjuId noviId =
                        new NapomenaIntervjuId
                        {
                            Intervju = intervju,
                            Napomena = novaNapomena
                        };

                    if (session.Get<NapomenaIntervju>(noviId) != null)
                        throw new Exception("Ova napomena već postoji.");

                    // Napomena je deo primarnog ključa,
                    // zato brišemo staru i pravimo novu.
                    session.Delete(stara);
                    session.Flush();

                    NapomenaIntervju nova =
                        new NapomenaIntervju
                        {
                            Id = noviId
                        };

                    session.Save(nova);

                    transaction.Commit();

                    return true;
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }

        #endregion
    }
}
