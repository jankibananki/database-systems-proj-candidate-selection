using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    internal class ZahteviOglasMapiranja : ClassMap<ZahtevOglas>
    {
        public ZahteviOglasMapiranja()
        {
            Table("ZAHTEVI_OGLAS");

            CompositeId()
                .KeyReference(x => x.Id.Oglas, "ID")
                .KeyProperty(x => x.Id.Zahtev, "ZAHTEV");
        }
    }
}
