using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    internal class CV
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DatumPodnosenja { get; set;}
        public virtual string Status { get; set; }
        public virtual string BrojTelefona { get; set; }

        public virtual Oglas Oglas { get; set; }

        public virtual IList<Intervju> Intervjui { get; set; }
        public virtual IList<Test> Testovi { get; set; }

        public CV()
        {
            Intervjui = new List<Intervju>();
            Testovi = new List<Test>();
        }
    }
}
