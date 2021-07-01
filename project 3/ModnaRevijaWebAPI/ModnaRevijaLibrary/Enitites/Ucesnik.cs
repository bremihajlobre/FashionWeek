using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Enitites
{
    public class Ucesnik
    {
        public virtual int MatBr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Pol { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
    }
}
