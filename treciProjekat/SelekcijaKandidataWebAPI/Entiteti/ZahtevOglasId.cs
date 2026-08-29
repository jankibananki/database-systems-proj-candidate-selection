using System;

namespace SelekcijaKandidata.Entiteti
{
    public class ZahtevOglasId
    {
        public virtual Oglas Oglas { get; set; }
        public virtual string Zahtev { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            ZahtevOglasId other = obj as ZahtevOglasId;

            if (other == null)
                return false;

            return Oglas.Id == other.Oglas.Id
                && Zahtev == other.Zahtev;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Oglas.Id, Zahtev);
        }
    }
}

