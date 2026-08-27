using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Mapiranja
{
    class SezonskiOglasMapiranja: SubclassMap<SezonskiOglas>
    {
        public SezonskiOglasMapiranja()
        {
            Table("SEZONSKI_OGLAS");
            KeyColumn("ID");

            Map(x => x.Sezona).Column("SEZONA");
            Map(x => x.Lokacija).Column("LOKACIJA");
        }
    }
}
