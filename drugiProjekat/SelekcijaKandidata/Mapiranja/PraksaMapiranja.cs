using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Mapiranja
{
    class PraksaMapiranja : SubclassMap<Praksa>
    {
        public PraksaMapiranja()
        {
            Table("PRAKSA");

            KeyColumn("ID");

            Map(x => x.TrajanjeMeseci)
                .Column("TRAJANJE_MESECI");

            References(x => x.Mentor)
                .Column("ID_ZAPOSLENOG")
                .Not.Nullable();
        }
    }
}
