using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    public class Zaposleni
    {

        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }

        public virtual IList<Intervju> Intervjui { get; set; }
        public virtual IList<Praksa> Prakse { get; set; }
        
        public Zaposleni() 
        { 
            Intervjui = new List<Intervju>();
            Prakse = new List<Praksa>();
        }
    }
}
