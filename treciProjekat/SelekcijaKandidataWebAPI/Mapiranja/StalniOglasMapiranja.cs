using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    class StalniOglasMapiranja : SubclassMap<StalniOglas>
    {

        public StalniOglasMapiranja()
        {
            Table("STALNI_OGLAS");
            KeyColumn("ID");
        }

    }
}
