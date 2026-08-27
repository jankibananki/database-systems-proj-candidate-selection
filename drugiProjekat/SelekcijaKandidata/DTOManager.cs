using NHibernate;
using NHibernate.Linq;
using SelekcijaKandidata.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata
{
    public class DTOManager
    {
        private static void IzvrsiUTransakciji(Action<ISession> akcija)
        {
            using (ISession session = DataLayer.GetSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    akcija(session);
                    transaction.Commit();
                }
                catch
                {
                    if (transaction.IsActive)
                        transaction.Rollback();

                    throw;
                }
            }
        }

        #region CV

        public static List<CVPregled> VratiSveCV()
        {
            using (ISession session = DataLayer.GetSession())
            {
                return session.Query<CV>()
                    .ToList()
                    .Select(c => new CVPregled
                    {
                        Id = c.Id,
                        Ime = c.Ime,
                        Prezime = c.Prezime,
                        Email = c.Email,
                        DatumPodnosenja = c.DatumPodnosenja,
                        Status = c.Status,
                        BrojTelefona = c.BrojTelefona
                    })
                    .OrderBy(c => c.Id)
                    .ToList();
            }
        }

        public static CVBasic VratiCV(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                CV c = session.Get<CV>(id);

                if (c == null)
                    return null;

                return new CVBasic
                {
                    Id = c.Id,
                    Ime = c.Ime,
                    Prezime = c.Prezime,
                    Email = c.Email,
                    DatumPodnosenja = c.DatumPodnosenja,
                    Status = c.Status,
                    BrojTelefona = c.BrojTelefona,
                    IdOglasa = c.Oglas.Id
                };
            }
        }

        public static void DodajCV(CVBasic dto)
        {
            IzvrsiUTransakciji(session =>
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
            });
        }

        public static void IzmeniCV(CVBasic dto)
        {
            IzvrsiUTransakciji(session =>
            {
                CV cv = session.Get<CV>(dto.Id);

                if (cv == null)
                    throw new Exception("CV nije pronađen.");

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
            });
        }

        public static void ObrisiCV(int id)
        {
            IzvrsiUTransakciji(session =>
            {
                CV cv = session.Get<CV>(id);

                if (cv == null)
                    throw new Exception("CV nije pronađen.");

                Odluka odluka = session.Query<Odluka>()
                    .FirstOrDefault(o => o.CV.Id == id);

                if (odluka != null)
                    session.Delete(odluka);

                session.Delete(cv);
            });
        }

        #endregion

        #region Oglasi lookup

        public static List<OglasLookup> VratiOglase()
        {
            using (ISession session = DataLayer.GetSession())
            {
                return session.Query<Oglas>()
                    .ToList()
                    .Select(o => new OglasLookup
                    {
                        Id = o.Id,
                        NazivPozicije = o.NazivPozicije
                    })
                    .OrderBy(o => o.Id)
                    .ToList();
            }
        }

        #endregion

        #region Kandidati lookup

        public static List<CVLookup> VratiKandidate()
        {
            using (ISession session = DataLayer.GetSession())
            {
                return session.Query<CV>()
                    .ToList()
                    .Select(c => new CVLookup
                    {
                        Id = c.Id,
                        Kandidat = c.Ime + " " + c.Prezime
                    })
                    .OrderBy(c => c.Id)
                    .ToList();
            }
        }

        #endregion

        #region Zaposleni lookup

        public static List<ZaposleniLookup> VratiZaposlene()
        {
            using (ISession session = DataLayer.GetSession())
            {
                return session.Query<Zaposleni>()
                    .ToList()
                    .Select(z => new ZaposleniLookup
                    {
                        Id = z.Id,
                        Zaposleni = z.Ime + " " + z.Prezime
                    })
                    .OrderBy(z => z.Id)
                    .ToList();
            }
        }

        #endregion

        #region Intervjui

        public static List<IntervjuPregled> VratiSveIntervjue()
        {
            using (ISession session = DataLayer.GetSession())
            {
                return session.Query<Intervju>()
                    .ToList()
                    .Select(i => new IntervjuPregled
                    {
                        Id = i.Id,
                        Kandidat = i.CV.Ime + " " + i.CV.Prezime,
                        DatumVreme = i.DatumVreme,
                        Tip = i.Tip,
                        Lokacija = i.Lokacija,
                        Zaposleni =
                            i.Zaposleni.Ime + " " +
                            i.Zaposleni.Prezime,
                        Ocena = i.Ocena
                    })
                    .OrderBy(i => i.Id)
                    .ToList();
            }
        }

        public static IntervjuBasic VratiIntervju(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Intervju i = session.Get<Intervju>(id);

                if (i == null)
                    return null;

                return new IntervjuBasic
                {
                    Id = i.Id,
                    IdCV = i.CV.Id,
                    DatumVreme = i.DatumVreme,
                    Tip = i.Tip,
                    Lokacija = i.Lokacija,
                    IdZaposlenog = i.Zaposleni.Id,
                    Ocena = i.Ocena
                };
            }
        }

        public static void DodajIntervju(IntervjuBasic dto)
        {
            IzvrsiUTransakciji(session =>
            {
                CV cv = session.Get<CV>(dto.IdCV);

                if (cv == null)
                    throw new Exception("Kandidat nije pronađen.");

                Zaposleni zaposleni =
                    session.Get<Zaposleni>(dto.IdZaposlenog);

                if (zaposleni == null)
                    throw new Exception("Zaposleni nije pronađen.");

                Intervju intervju = new Intervju
                {
                    CV = cv,
                    DatumVreme = dto.DatumVreme,
                    Tip = dto.Tip,
                    Lokacija = dto.Lokacija,
                    Zaposleni = zaposleni,
                    Ocena = dto.Ocena
                };

                session.Save(intervju);
            });
        }

        public static void IzmeniIntervju(IntervjuBasic dto)
        {
            IzvrsiUTransakciji(session =>
            {
                Intervju intervju =
                    session.Get<Intervju>(dto.Id);

                if (intervju == null)
                    throw new Exception(
                        "Intervju nije pronađen.");

                CV cv = session.Get<CV>(dto.IdCV);

                if (cv == null)
                    throw new Exception(
                        "Kandidat nije pronađen.");

                Zaposleni zaposleni =
                    session.Get<Zaposleni>(
                        dto.IdZaposlenog);

                if (zaposleni == null)
                    throw new Exception(
                        "Zaposleni nije pronađen.");

                intervju.CV = cv;
                intervju.DatumVreme = dto.DatumVreme;
                intervju.Tip = dto.Tip;
                intervju.Lokacija = dto.Lokacija;
                intervju.Zaposleni = zaposleni;
                intervju.Ocena = dto.Ocena;

                session.Update(intervju);
            });
        }

        public static void ObrisiIntervju(int id)
        {
            IzvrsiUTransakciji(session =>
            {
                Intervju intervju =
                    session.Get<Intervju>(id);

                if (intervju == null)
                    throw new Exception(
                        "Intervju nije pronađen.");

                session.Delete(intervju);
            });
        }

        #endregion

        #region Napomene intervjua

        public static List<NapomenaIntervjuBasic>
            VratiNapomeneIntervjua(int idIntervjua)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Intervju intervju =
                    session.Get<Intervju>(idIntervjua);

                if (intervju == null)
                    return new List<NapomenaIntervjuBasic>();

                return intervju.Napomene
                    .Select(n => new NapomenaIntervjuBasic
                    {
                        IdIntervjua = idIntervjua,
                        Napomena = n.Id.Napomena
                    })
                    .OrderBy(n => n.Napomena)
                    .ToList();
            }
        }

        public static void DodajNapomenu(
            int idIntervjua,
            string tekst)
        {
            IzvrsiUTransakciji(session =>
            {
                Intervju intervju =
                    session.Get<Intervju>(idIntervjua);

                if (intervju == null)
                    throw new Exception(
                        "Intervju nije pronađen.");

                NapomenaIntervjuId id =
                    new NapomenaIntervjuId
                    {
                        Intervju = intervju,
                        Napomena = tekst
                    };

                if (session.Get<NapomenaIntervju>(id) != null)
                    throw new Exception(
                        "Ova napomena već postoji.");

                NapomenaIntervju napomena =
                    new NapomenaIntervju
                    {
                        Id = id
                    };

                session.Save(napomena);
            });
        }

        public static void IzmeniNapomenu(
            int idIntervjua,
            string staraNapomena,
            string novaNapomena)
        {
            IzvrsiUTransakciji(session =>
            {
                Intervju intervju =
                    session.Get<Intervju>(idIntervjua);

                if (intervju == null)
                    throw new Exception(
                        "Intervju nije pronađen.");

                NapomenaIntervjuId stariId =
                    new NapomenaIntervjuId
                    {
                        Intervju = intervju,
                        Napomena = staraNapomena
                    };

                NapomenaIntervju stara =
                    session.Get<NapomenaIntervju>(stariId);

                if (stara == null)
                    throw new Exception(
                        "Napomena nije pronađena.");

                if (staraNapomena == novaNapomena)
                    return;

                NapomenaIntervjuId noviId =
                    new NapomenaIntervjuId
                    {
                        Intervju = intervju,
                        Napomena = novaNapomena
                    };

                if (session.Get<NapomenaIntervju>(noviId) != null)
                    throw new Exception(
                        "Ova napomena već postoji.");

                session.Delete(stara);
                session.Flush();

                session.Save(
                    new NapomenaIntervju
                    {
                        Id = noviId
                    });
            });
        }

        public static void ObrisiNapomenu(
            int idIntervjua,
            string tekst)
        {
            IzvrsiUTransakciji(session =>
            {
                Intervju intervju =
                    session.Get<Intervju>(idIntervjua);

                if (intervju == null)
                    throw new Exception(
                        "Intervju nije pronađen.");

                NapomenaIntervjuId id =
                    new NapomenaIntervjuId
                    {
                        Intervju = intervju,
                        Napomena = tekst
                    };

                NapomenaIntervju napomena =
                    session.Get<NapomenaIntervju>(id);

                if (napomena == null)
                    throw new Exception(
                        "Napomena nije pronađena.");

                session.Delete(napomena);
            });
        }

        #endregion

        #region Odluka

        public static List<OdlukaBasic> VratiSveOdluke()
        {
            using (ISession session = DataLayer.GetSession())
            {
                return session.Query<Odluka>()
                    .ToList()
                    .Select(o => new OdlukaBasic
                    {
                        Id = o.Id,
                        Datum = o.Datum,
                        PocetakRada = o.PocetakRada,
                        Prihvaceno = o.Prihvaceno,
                        Status = o.Status,
                        Plata = o.Plata,
                        RazlogOdbijanja = o.RazlogOdbijanja,
                        IdCV = o.CV.Id,
                        ImePrezimeKandidata = o.CV.Ime + " " + o.CV.Prezime
                    })
                    .OrderBy(o => o.Id)
                    .ToList();
            }
        }

        public static void DodajOdluku(OdlukaBasic dto)
        {
            IzvrsiUTransakciji(session =>
            {
                CV cv = session.Get<CV>(dto.IdCV)
                    ?? throw new Exception("CV nije pronadjen.");

                if (session.Query<Odluka>().Any(o => o.CV.Id == dto.IdCV))
                    throw new Exception("Ovaj CV vec ima donetu odluku.");

                session.Save(new Odluka
                {
                    Datum = dto.Datum,
                    PocetakRada = dto.PocetakRada,
                    Prihvaceno = dto.Prihvaceno,
                    Status = dto.Status,
                    Plata = dto.Plata,
                    RazlogOdbijanja = dto.RazlogOdbijanja,
                    CV = cv
                });
            });
        }

        public static void IzmeniOdluku(OdlukaBasic dto)
        {
            IzvrsiUTransakciji(session =>
            {
                Odluka o = session.Get<Odluka>(dto.Id)
                    ?? throw new Exception("Odluka nije pronadjena.");

                o.Datum = dto.Datum;
                o.PocetakRada = dto.PocetakRada;
                o.Prihvaceno = dto.Prihvaceno;
                o.Status = dto.Status;
                o.Plata = dto.Plata;
                o.RazlogOdbijanja = dto.RazlogOdbijanja;

                session.Update(o);
            });
        }

        public static void ObrisiOdluku(int id)
        {
            IzvrsiUTransakciji(session =>
            {
                Odluka o = session.Get<Odluka>(id)
                    ?? throw new Exception("Odluka nije pronadjena.");
                session.Delete(o);
            });
        }

        #endregion

        #region Oglasi

        public static List<OglasPregled> VratiSveOglase()
        {
            using (ISession session = DataLayer.GetSession())
            {
                return session.Query<Oglas>()
                    .OrderBy(o => o.Id)
                    .Select(o => new OglasPregled
                    {
                        Id = o.Id,
                        NazivPozicije = o.NazivPozicije,
                        VrstaOglasa = o.VrstaOglasa,
                        Opis = o.Opis,
                        MinPlata = o.MinPlata,
                        MaxPlata = o.MaxPlata,
                        DatumObjave = o.DatumObjave,
                        DatumZatvaranja = o.DatumZatvaranja,
                        Status = o.Status
                    })
                    .ToList();
            }
        }

        public static PraksaBasic VratiPraksu(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                Praksa p = session.Get<Praksa>(id);
                if (p == null) return null;

                return new PraksaBasic
                {
                    Id = p.Id,
                    NazivPozicije = p.NazivPozicije,
                    Opis = p.Opis,
                    DatumObjave = p.DatumObjave,
                    DatumZatvaranja = p.DatumZatvaranja,
                    Status = p.Status,
                    TrajanjeMeseci = p.TrajanjeMeseci,
                    IdMentora = p.Mentor.Id,
                    ImePrezimeMentora = p.Mentor.Ime + " " + p.Mentor.Prezime
                };
            }
        }

        public static void DodajPraksu(PraksaBasic dto)
        {
            IzvrsiUTransakciji(session =>
            {
                Zaposleni mentor = session.Get<Zaposleni>(dto.IdMentora)
                    ?? throw new Exception("Mentor (zaposleni) nije pronadjen.");

                Praksa p = new Praksa
                {
                    NazivPozicije = dto.NazivPozicije,
                    VrstaOglasa = "praksa",
                    Opis = dto.Opis,
                    DatumObjave = dto.DatumObjave,
                    DatumZatvaranja = dto.DatumZatvaranja,
                    Status = dto.Status,
                    TrajanjeMeseci = dto.TrajanjeMeseci,
                    Mentor = mentor
                };

                session.Save(p);
            });
        }

        public static PrivremeniOglasBasic VratiPrivremeniOglas(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                PrivremeniOglas o = session.Get<PrivremeniOglas>(id);
                if (o == null) return null;

                return new PrivremeniOglasBasic
                {
                    Id = o.Id,
                    NazivPozicije = o.NazivPozicije,
                    Opis = o.Opis,
                    DatumObjave = o.DatumObjave,
                    DatumZatvaranja = o.DatumZatvaranja,
                    Status = o.Status,
                    Projekat = o.Projekat,
                    PeriodAngazovanja = o.PeriodAngazovanja
                };
            }
        }

        public static void DodajPrivremeniOglas(PrivremeniOglasBasic dto)
        {
            IzvrsiUTransakciji(session =>
            {
                session.Save(new PrivremeniOglas
                {
                    NazivPozicije = dto.NazivPozicije,
                    VrstaOglasa = "privremeni rad",
                    Opis = dto.Opis,
                    DatumObjave = dto.DatumObjave,
                    DatumZatvaranja = dto.DatumZatvaranja,
                    Status = dto.Status,
                    Projekat = dto.Projekat,
                    PeriodAngazovanja = dto.PeriodAngazovanja
                });
            });
        }

        public static SezonskiOglasBasic VratiSezonskiOglas(int id)
        {
            using (ISession session = DataLayer.GetSession())
            {
                SezonskiOglas o = session.Get<SezonskiOglas>(id);
                if (o == null) return null;

                return new SezonskiOglasBasic
                {
                    Id = o.Id,
                    NazivPozicije = o.NazivPozicije,
                    Opis = o.Opis,
                    DatumObjave = o.DatumObjave,
                    DatumZatvaranja = o.DatumZatvaranja,
                    Status = o.Status,
                    Sezona = o.Sezona,
                    Lokacija = o.Lokacija
                };
            }
        }

        public static void DodajSezonskiOglas(SezonskiOglasBasic dto)
        {
            IzvrsiUTransakciji(session =>
            {
                session.Save(new SezonskiOglas
                {
                    NazivPozicije = dto.NazivPozicije,
                    VrstaOglasa = "sezonski rad",
                    Opis = dto.Opis,
                    DatumObjave = dto.DatumObjave,
                    DatumZatvaranja = dto.DatumZatvaranja,
                    Status = dto.Status,
                    Sezona = dto.Sezona,
                    Lokacija = dto.Lokacija
                });
            });
        }

        public static void DodajStalniOglas(StalniOglasBasic dto)
        {
            IzvrsiUTransakciji(session =>
            {
                session.Save(new StalniOglas
                {
                    NazivPozicije = dto.NazivPozicije,
                    VrstaOglasa = "stalni rad",
                    Opis = dto.Opis,
                    DatumObjave = dto.DatumObjave,
                    DatumZatvaranja = dto.DatumZatvaranja,
                    Status = dto.Status
                });
            });
        }

        public static void ObrisiOglas(int id)
        {
            IzvrsiUTransakciji(session =>
            {
                Oglas o = session.Get<Oglas>(id)
                    ?? throw new Exception("Oglas nije pronadjen.");

                var zahtevi = session.Query<ZahtevOglas>()
                    .Where(z => z.Id.Oglas.Id == id)
                    .ToList();
                foreach (var z in zahtevi)
                    session.Delete(z);

                var cvjevi = session.Query<CV>()
                    .Where(c => c.Oglas.Id == id)
                    .ToList();

                foreach (var cv in cvjevi)
                {
                    var intervjui = session.Query<Intervju>()
                        .Where(i => i.CV.Id == cv.Id)
                        .ToList();
                    foreach (var i in intervjui)
                    {
                        var napomene = session.Query<NapomenaIntervju>()
                            .Where(n => n.Id.Intervju.Id == i.Id)
                            .ToList();
                        foreach (var n in napomene)
                            session.Delete(n);

                        session.Delete(i);
                    }

                    var testovi = session.Query<Test>()
                        .Where(t => t.CV.Id == cv.Id)
                        .ToList();
                    foreach (var t in testovi)
                        session.Delete(t);

                    var odluka = session.Query<Odluka>()
                        .FirstOrDefault(od => od.CV.Id == cv.Id);
                    if (odluka != null)
                        session.Delete(odluka);

                    session.Delete(cv);
                }

                session.Delete(o);
            });
        }

        #endregion
    }
}
