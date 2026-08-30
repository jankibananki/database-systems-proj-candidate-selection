using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidataWebAPI.DTOs
{
    public class PraksaView
    {
        public int Id { get; set; }
        public string? NazivPozicije { get; set; }
        public string? Opis { get; set; }
        public decimal? MinPlata { get; set; }
        public decimal? MaxPlata { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime? DatumZatvaranja { get; set; }
        public string? Status { get; set; }
        public int TrajanjeMeseci { get; set; }
        public int IdMentora { get; set; }

        public PraksaView() { }

        public PraksaView(Praksa oglas)
        {
            Id = oglas.Id;
            NazivPozicije = oglas.NazivPozicije;
            Opis = oglas.Opis;
            MinPlata = oglas.MinPlata;
            MaxPlata = oglas.MaxPlata;
            DatumObjave = oglas.DatumObjave;
            DatumZatvaranja = oglas.DatumZatvaranja;
            Status = oglas.Status;
            TrajanjeMeseci = oglas.TrajanjeMeseci;
            IdMentora = oglas.Mentor.Id;
        }
    }
}
