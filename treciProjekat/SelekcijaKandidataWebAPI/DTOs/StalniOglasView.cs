using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidataWebAPI.DTOs
{
    public class StalniOglasView
    {
        public int Id { get; set; }
        public string? NazivPozicije { get; set; }
        public string? Opis { get; set; }
        public decimal? MinPlata { get; set; }
        public decimal? MaxPlata { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime? DatumZatvaranja { get; set; }
        public string? Status { get; set; }

        public StalniOglasView() { }

        public StalniOglasView(StalniOglas oglas)
        {
            Id = oglas.Id;
            NazivPozicije = oglas.NazivPozicije;
            Opis = oglas.Opis;
            MinPlata = oglas.MinPlata;
            MaxPlata = oglas.MaxPlata;
            DatumObjave = oglas.DatumObjave;
            DatumZatvaranja = oglas.DatumZatvaranja;
            Status = oglas.Status;
        }
    }
}
