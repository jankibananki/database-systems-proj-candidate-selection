using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    class NapomenaIntervjuMapiranja: ClassMap<NapomenaIntervju>
    {
        public NapomenaIntervjuMapiranja()
        {
            Table("NAPOMENA_INTERVJU");

            CompositeId(x => x.Id)
                .KeyReference(x => x.Intervju, "ID_INTERVJUA")
                .KeyProperty(x => x.Napomena, "NAPOMENA");
        }
    }
}
