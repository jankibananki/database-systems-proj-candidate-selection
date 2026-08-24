using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    internal class PrivremeniOglas : Oglas
    {
        public virtual string Projekat {  get; set; }
        public virtual string PeriodAngazovanja { get; set; }
    }
}
