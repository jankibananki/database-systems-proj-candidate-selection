namespace SelekcijaKandidataWebAPI.DTOs
{
    public class TestView
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public required virtual string Vrsta { get; set; }
        public virtual int? Rezultat { get; set; }
        public virtual string? Komentar { get; set; }
        public required virtual int CVId { get; set; }
    }
}