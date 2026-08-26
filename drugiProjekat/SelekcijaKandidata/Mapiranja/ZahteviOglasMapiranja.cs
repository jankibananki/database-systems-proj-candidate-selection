using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;

namespace SelekcijaKandidata.Mapiranja
{
    internal class ZahteviOglasMapiranja : ClassMap<ZahtevOglas>
    {
        public ZahteviOglasMapiranja()
        {
            Table("ZAHTEVI_OGLAS");

            CompositeId(x=>x.Id)
                .KeyReference(x => x.Oglas, "ID")
                .KeyProperty(x => x.Zahtev, "ZAHTEV");
        }
    }
}
