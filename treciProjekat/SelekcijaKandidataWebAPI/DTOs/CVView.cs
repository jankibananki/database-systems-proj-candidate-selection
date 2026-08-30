namespace SelekcijaKandidataWebAPI.DTOs
{
    public class CVView
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
}
