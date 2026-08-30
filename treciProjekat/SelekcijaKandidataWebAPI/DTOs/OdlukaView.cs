using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidataWebAPI.DTOs
{
    public class OdlukaView
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public DateTime? PocetakRada { get; set; }
        public int? Prihvaceno { get; set; }
        public string? Status { get; set; }
        public decimal? Plata { get; set; }
        public string? RazlogOdbijanja { get; set; }
        public int IdCV { get; set; }

        public OdlukaView() { }

        public OdlukaView(Odluka odluka)
        {
            Id = odluka.Id;
            Datum = odluka.Datum;
            PocetakRada = odluka.PocetakRada;
            Prihvaceno = odluka.Prihvaceno;
            Status = odluka.Status;
            Plata = odluka.Plata;
            RazlogOdbijanja = odluka.RazlogOdbijanja;
            IdCV = odluka.CV.Id;
        }
    }
}
