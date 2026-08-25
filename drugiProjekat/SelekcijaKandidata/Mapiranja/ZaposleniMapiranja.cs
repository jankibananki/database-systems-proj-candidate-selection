using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    internal class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            Id(x => x.Id).Column("ID").GeneratedBy.Increment();
            Map(x => x.Ime).Column("IME").Length(50).Not.Nullable();
            Map(x => x.Prezime).Column("PREZIME").Length(50).Not.Nullable();

            HasMany(x => x.Intervjui)
                .KeyColumn("ID_ZAPOSLENOG")
                .Inverse()
                .LazyLoad();

            HasMany(x => x.Prakse)
                .KeyColumn("ID_ZAPOSLENOG")
                .Inverse()
                .LazyLoad();
        }
    }
}
