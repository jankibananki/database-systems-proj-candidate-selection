namespace SelekcijaKandidataWebAPI.DTOs
{
    public class OglasView
    {
        public int Id { get; set; }
        public string? NazivPozicije { get; set; }
        public string? VrstaOglasa { get; set; }
        public string? Opis { get; set; }
        public decimal? MinPlata { get; set; }
        public decimal? MaxPlata { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime? DatumZatvaranja { get; set; }
        public string? Status { get; set; }

        public OglasView() { }

        public OglasView(Oglas oglas)
        {
            Id = oglas.Id;
            NazivPozicije = oglas.NazivPozicije;
            VrstaOglasa = oglas.VrstaOglasa;
            Opis = oglas.Opis;
            MinPlata = oglas.MinPlata;
            MaxPlata = oglas.MaxPlata;
            DatumObjave = oglas.DatumObjave;
            DatumZatvaranja = oglas.DatumZatvaranja;
            Status = oglas.Status;
        }
    }
}
