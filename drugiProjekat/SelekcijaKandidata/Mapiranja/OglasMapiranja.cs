using FluentNHibernate.Mapping;
using SelekcijaKandidata.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Mapiranja
{
    class OglasMapiranja : ClassMap<Oglas>
    {
        public OglasMapiranja() 
        {

            Table("OGLAS");

            Id(x => x.Id)
                .Column("ID")
                .GeneratedBy.Increment();

            Map(x => x.NazivPozicije)
                .Column("NAZIV_POZICIJE");

            Map(x => x.VrstaOglasa)
                .Column("VRSTA_OGLASA");

            Map(x => x.Opis)
                .Column("OPIS");

            Map(x => x.MinPlata)
                .Column("MIN_PLATA");

            Map(x => x.MaxPlata)
                .Column("MAX_PLATA");

            Map(x => x.DatumObjave)
                .Column("DATUM_OBJAVE");

            Map(x => x.DatumZatvaranja)
                .Column("DATUM_ZATVARANJA");

            Map(x => x.Status)
                .Column("STATUS");

            HasMany(x => x.CVjevi)
                .KeyColumn("ID_OGLASA")
                .LazyLoad()
                .Inverse();

            HasMany(x => x.Zahtevi)
                .KeyColumn("ID")
                .LazyLoad()
                .Inverse();
        }

    }
}
