using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidataWebAPI.DTOs
{
    public class PrivremeniOglasView
    {
        public int Id { get; set; }
        public string? NazivPozicije { get; set; }
        public string? Opis { get; set; }
        public decimal? MinPlata { get; set; }
        public decimal? MaxPlata { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime? DatumZatvaranja { get; set; }
        public string? Status { get; set; }
        public string? Projekat { get; set; }
        public string? PeriodAngazovanja { get; set; }

        public PrivremeniOglasView() { }

        public PrivremeniOglasView(PrivremeniOglas oglas)
        {
            Id = oglas.Id;
            NazivPozicije = oglas.NazivPozicije;
            Opis = oglas.Opis;
            MinPlata = oglas.MinPlata;
            MaxPlata = oglas.MaxPlata;
            DatumObjave = oglas.DatumObjave;
            DatumZatvaranja = oglas.DatumZatvaranja;
            Status = oglas.Status;
            Projekat = oglas.Projekat;
            PeriodAngazovanja = oglas.PeriodAngazovanja;
        }
    }
}
