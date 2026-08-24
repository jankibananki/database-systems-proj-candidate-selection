using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    internal class SezonskiOglas : Oglas
    {
        public virtual string Sezona { get; set; }
        public virtual string Lokacija { get; set; }
    }
}
