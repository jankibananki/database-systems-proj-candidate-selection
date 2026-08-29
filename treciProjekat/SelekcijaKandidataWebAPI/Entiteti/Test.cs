using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    public class Test
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual string Vrsta { get; set; }
        public virtual int? Rezultat { get; set; }
        public virtual string Komentar { get; set; }
        
        public virtual CV CV { get; set; }
    }
}
