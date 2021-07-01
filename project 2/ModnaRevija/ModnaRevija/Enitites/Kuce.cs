using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Enitites
{
    public class Kuce
    {
        public virtual int Id { get; protected set; }
       // public virtual int MatbrKreator { get; set; }
        public virtual string Naziv { get; set; }

        public virtual ModniKreator ModniKreator { get; set; }
    }
}
