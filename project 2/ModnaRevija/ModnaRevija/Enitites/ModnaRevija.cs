using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Enitites
{
    public class ModnaRevija
    {
        public virtual int Id { get; protected set; }
        public virtual int Rbr { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Mesto { get; set; }
        public virtual DateTime DatumVremeOdrzavanja { get; set; }

        public virtual IList<SpecGost> SpecijalniGosti { get; set; }

        public virtual IList<Maneken> Manekeni { get; set; }

        public virtual IList<Predstavlja> MKreatorNaMReviji { get; set; }
        public ModnaRevija()
        {
            SpecijalniGosti = new List<SpecGost>();
            Manekeni = new List<Maneken>();
            MKreatorNaMReviji = new List<Predstavlja>();
        }
    }
}
