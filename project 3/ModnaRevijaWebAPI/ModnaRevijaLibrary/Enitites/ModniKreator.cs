using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Enitites
{
    public class ModniKreator : Ucesnik
    {
        //public virtual int Matbr { get; set; }
        public virtual string Zemlja { get; set; }

        public virtual IList<Kuce> Kuce { get; set; }

        public virtual IList<Predstavlja> Revije { get; set; }
        public ModniKreator()
        {
            Kuce = new List<Kuce>();
            Revije = new List<Predstavlja>();
        }
    }
}
