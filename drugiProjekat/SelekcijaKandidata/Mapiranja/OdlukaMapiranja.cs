using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    class OdlukaMapiranja: ClassMap<Odluka>
    {
        public OdlukaMapiranja()
        {
            Table("ODLUKA");
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Datum, "DATUM");
            Map(x => x.PocetakRada, "POCETAK_RADA");
            Map(x => x.Prihvaceno, "PRIHVACENO");
            Map(x => x.Status, "STATUS");
            Map(x => x.Plata, "PLATA");
            Map(x => x.RazlogOdbijanja, "RAZLOG_ODBIJANJA");

            References(x => x.CV)
                .Column("ID_CV")
                .Unique()
                .LazyLoad();
        }
    }
}
