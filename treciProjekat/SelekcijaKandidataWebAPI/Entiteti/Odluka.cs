using System;

namespace SelekcijaKandidata.Entiteti
{
    public class Odluka
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual DateTime? PocetakRada { get; set; }
        public virtual int? Prihvaceno { get; set; }
        public virtual string Status { get; set; }
        public virtual decimal? Plata { get; set; }
        public virtual string RazlogOdbijanja { get; set; }

        public virtual CV CV { get; set; }
    }
}
