using System;

namespace SelekcijaKandidata.Entiteti
{
    public class NapomenaIntervjuId
    {
        public virtual Intervju Intervju { get; set; }
        public virtual string Napomena { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            NapomenaIntervjuId other = obj as NapomenaIntervjuId;
            if (other == null)
                return false;

            return Intervju.Id == other.Intervju.Id
                && Napomena == other.Napomena;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Intervju.Id, Napomena);
        }
    }
}
