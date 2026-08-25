using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    class CVMapiranja: ClassMap<CV>
    {
        public CVMapiranja()
        {
            Table("CV");
            Id(x => x.Id, "ID").GeneratedBy.Increment();
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Email, "EMAIL");
            Map(x => x.DatumPodnosenja, "DATUM_PODNOSENJA");
            Map(x => x.Status, "STATUS");
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");

            References(x => x.Oglas)
                .Column("ID_OGLASA")
                .LazyLoad();

            HasMany(x => x.Intervjui)
                .KeyColumn("ID_CV")
                .Inverse()
                .Cascade.All()
                .LazyLoad();

            HasMany(x => x.Testovi)
                .KeyColumn("ID_CV")
                .Inverse()
                .Cascade.All()
                .LazyLoad();
        }
    }
}
