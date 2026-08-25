using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    class PrivremeniOglasMapiranja : SubclassMap<PrivremeniOglas>
    {
        public PrivremeniOglasMapiranja()
        {
            Table("PRIVREMENI_OGLAS");

            KeyColumn("ID");

            Map(x => x.Projekat)
                .Column("PROJEKAT");

            Map(x => x.PeriodAngazovanja)
                .Column("PERIOD_ANGAZOVANJA");
        }

    }
}
