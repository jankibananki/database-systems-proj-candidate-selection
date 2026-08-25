using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    public class ZahtevOglas
    {
        public virtual ZahtevOglasId Id { get; set; }

        public ZahtevOglas()
        {
            Id = new ZahtevOglasId();
        }
    }
}
