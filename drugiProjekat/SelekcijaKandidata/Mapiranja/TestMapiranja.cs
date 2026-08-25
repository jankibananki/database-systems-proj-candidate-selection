using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    internal class TestMapiranja : ClassMap<Test>
    {
        public TestMapiranja()
        {
            Table("TEST");

            Id(x => x.Id).Column("ID").GeneratedBy.Assigned();
            Map(x => x.Datum).Column("DATUM").Not.Nullable();
            Map(x => x.Vrsta).Column("VRSTA").Length(100).Not.Nullable();
            Map(x => x.Rezultat).Column("REZULTAT");
            Map(x => x.Komentar).Column("KOMENTAR").Length(50);
            References(x => x.CV).Column("ID_CV").Not.Nullable().LazyLoad();
        }
    }
}