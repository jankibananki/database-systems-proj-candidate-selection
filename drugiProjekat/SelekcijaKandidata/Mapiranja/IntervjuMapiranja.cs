using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    class IntervjuMapiranja: ClassMap<Intervju>
    {
        public IntervjuMapiranja()
        {
            Table("INTERVJU");
            Id(x => x.Id, "ID").GeneratedBy.Increment();
            Map(x => x.Tip, "TIP");
            Map(x => x.DatumVreme, "DATUM_VREME");
            Map(x => x.Lokacija, "LOKACIJA");
            Map(x => x.Ocena, "OCENA");

            References(x => x.CV)
                .Column("ID_CV")
                .LazyLoad();

            References(x => x.Zaposleni)
                .Column("ID_ZAPOSLENOG")
                .LazyLoad();

            HasMany(x => x.Napomene)
                .KeyColumn("ID_INTERVJUA")
                .Inverse()
                .Cascade.All()
                .LazyLoad();
        }
    }
}
