namespace SelekcijaKandidataWebAPI.DTOs
{
    public class IntervjuView
    {
        public int Id { get; set; }

        public string Tip { get; set; }

        public DateTime DatumVreme { get; set; }

        public string Lokacija { get; set; }

        public int? Ocena { get; set; }

        public int IdCV { get; set; }

        public int IdZaposlenog { get; set; }
    }
}
