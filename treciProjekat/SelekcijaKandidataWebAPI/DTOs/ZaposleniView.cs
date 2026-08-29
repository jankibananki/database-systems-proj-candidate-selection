namespace SelekcijaKandidataWebAPI.DTOs
{
    /// <summary>
    /// DTO (Data Transfer Object) za Zaposlenog.
    /// Koristi se za transfer podataka između Web API-ja i klijenta.
    /// Sadrži samo osnovne podatke neophodne za API odgovore.
    /// </summary>
    public class ZaposleniView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
