using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    internal class Odluka
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual DateTime? PocetakRada { get; set; }
        //u bazu je numeric ili number sta vec mora bude int
        public virtual int? Prihvaceno { get; set; }
        public virtual string Status { get; set; }
        public virtual decimal? Plata { get; set; }
        public virtual string RazlogOdbijanja { get; set; }

        public virtual CV CV { get; set; }
    }
}
