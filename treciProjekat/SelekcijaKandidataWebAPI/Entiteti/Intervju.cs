using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelekcijaKandidata.Entiteti
{
    public class Intervju
    {
        public virtual int Id { get; set; }
        public virtual string Tip { get; set; }
        public virtual DateTime DatumVreme { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual int? Ocena { get; set; }

        public virtual CV CV { get; set; }
        public virtual Zaposleni Zaposleni { get; set; }
        
        public virtual IList<NapomenaIntervju> Napomene {  get; set; }

        public Intervju()
        {
            Napomene = new List<NapomenaIntervju>();
        }
    }
}
