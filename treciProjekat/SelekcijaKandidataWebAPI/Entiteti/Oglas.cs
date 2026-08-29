using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    public class Oglas
    {

        public virtual int Id { get; set; }
        public virtual string NazivPozicije { get; set; }
        public virtual string VrstaOglasa { get; set; }
        public virtual string Opis { get; set; }
        public virtual decimal? MinPlata { get; set; }
        public virtual decimal? MaxPlata { get;set; }
        public virtual DateTime DatumObjave { get; set; }
        public virtual DateTime? DatumZatvaranja { get; set; }
        public virtual string Status { get; set; }

        public virtual IList<CV> CVjevi {  get; set; }
        public virtual IList<ZahtevOglas> Zahtevi { get; set; }

        public Oglas() 
        {
            CVjevi = new List<CV>();
            Zahtevi = new List<ZahtevOglas>();
        }
    }
}
