using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    internal class Praksa : Oglas
    {
        public virtual int TrajanjeMeseci {  get; set; }
        public virtual Zaposleni Mentor {  get; set; }
    }
}
