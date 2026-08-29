using System;

namespace SelekcijaKandidata
{
    #region CV

    public class CVPregled
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime DatumPodnosenja { get; set; }
        public string Status { get; set; }
        public string BrojTelefona { get; set; }
    }

    public class CVBasic
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime DatumPodnosenja { get; set; }
        public string Status { get; set; }
        public string BrojTelefona { get; set; }
        public int IdOglasa { get; set; }
    }

    public class CVLookup
    {
        public int Id { get; set; }
        public string Kandidat { get; set; }
    }

    #endregion

    #region Zaposleni

    public class ZaposleniLookup
    {
        public int Id { get; set; }
        public string Zaposleni { get; set; }
    }

    public class ZaposleniBasic
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }

    #endregion

    #region Intervjui

    public class IntervjuPregled
    {
        public int Id { get; set; }
        public string Kandidat { get; set; }
        public DateTime DatumVreme { get; set; }
        public string Tip { get; set; }
        public string Lokacija { get; set; }
        public string Zaposleni { get; set; }
        public int? Ocena { get; set; }
    }

    public class IntervjuBasic
    {
        public int Id { get; set; }
        public int IdCV { get; set; }
        public DateTime DatumVreme { get; set; }
        public string Tip { get; set; }
        public string Lokacija { get; set; }
        public int IdZaposlenog { get; set; }
        public int? Ocena { get; set; }
    }

    public class NapomenaIntervjuBasic
    {
        public int IdIntervjua { get; set; }
        public string Napomena { get; set; }
    }

    #endregion

    #region Odluka

    public class OdlukaBasic
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public DateTime? PocetakRada { get; set; }
        public int? Prihvaceno { get; set; }
        public string Status { get; set; }
        public decimal? Plata { get; set; }
        public string RazlogOdbijanja { get; set; }
        public int IdCV { get; set; }
        public string ImePrezimeKandidata { get; set; }
    }

    #endregion

    #region Oglasi

    public class OglasLookup
    {
        public int Id { get; set; }
        public string NazivPozicije { get; set; }
    }
    public class OglasPregled
    {
        public int Id { get; set; }
        public string NazivPozicije { get; set; }
        public string VrstaOglasa { get; set; }
        public string Opis { get; set; }
        public decimal? MinPlata { get; set; }
        public decimal? MaxPlata { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime? DatumZatvaranja { get; set; }
        public string Status { get; set; }
    }

    public class StalniOglasBasic : OglasPregled
    {
    }

    public class PrivremeniOglasBasic : OglasPregled
    {
        public string Projekat { get; set; }
        public string PeriodAngazovanja { get; set; }
    }

    public class SezonskiOglasBasic : OglasPregled
    {
        public string Sezona { get; set; }
        public string Lokacija { get; set; }
    }

    public class PraksaBasic : OglasPregled
    {
        public int TrajanjeMeseci { get; set; }
        public int IdMentora { get; set; }
        public string ImePrezimeMentora { get; set; }
    }

    public class ZahtevOglasBasic
    {
        public int IdOglasa { get; set; }
        public string Zahtev { get; set; }
    }

    #endregion

    #region Testovi

    public class TestPregled
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Vrsta { get; set; }
        public int? Rezultat { get; set; }
        public string Komentar { get; set; }
        public string Kandidat { get; set; }
        public int IdCV { get; set; }
    }

    public class TestBasic
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Vrsta { get; set; }
        public int? Rezultat { get; set; }
        public string Komentar { get; set; }
        public int IdCV { get; set; }
    }

    #endregion

}
