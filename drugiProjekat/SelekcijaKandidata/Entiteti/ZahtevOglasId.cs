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
            unchecked
            {
                int hash = 17;
                hash = hash * 31 + Id.GetHashCode();
                hash = hash * 31 + (Zahtev == null ? 0 : Zahtev.GetHashCode());
                return hash;
            }
        }
    }
}
