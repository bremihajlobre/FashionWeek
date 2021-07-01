using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Enitites
{
    public class ModnaAgencija
    {
        public virtual int Pib { get; set; }
        public virtual string NazivAgencije { get; set; }
        public virtual string Sediste { get; set; }
        public virtual DateTime DatumOsnivanja { get; set; }

        public virtual IList<Maneken> Manekeni { get; set; }

        public ModnaAgencija()
        {
            Manekeni = new List<Maneken>();
        }
    }
}
