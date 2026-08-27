using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata
{
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

    public class OglasLookup
    {
        public int Id { get; set; }
        public string NazivPozicije { get; set; }
    }

    public class CVLookup
    {
        public int Id { get; set; }
        public string Kandidat { get; set; }
    }

    public class ZaposleniLookup
    {
        public int Id { get; set; }
        public string Zaposleni { get; set; }
    }

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
}
