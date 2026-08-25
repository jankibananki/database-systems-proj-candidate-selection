namespace SelekcijaKandidata.Entiteti
{
    public class ZahtevOglasId
    {
        public virtual int Id { get; set; }
        public virtual string Zahtev { get; set; }

        public override bool Equals(object obj)
        {
            ZahtevOglasId other = obj as ZahtevOglasId;

            if (other == null)
                return false;

            return Id == other.Id && Zahtev == other.Zahtev;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Oglas.Id, Zahtev);
        }
    }
}
