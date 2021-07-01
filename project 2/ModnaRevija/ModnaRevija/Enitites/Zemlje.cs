using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Enitites
{
    public class Zemlje
    {
        public virtual int Id { get; protected set; }
        public virtual int PibAgencija { get; set; }
        public virtual string Naziv { get; set; }

        public virtual Internacionalna InternacionalnaMAgencija { get; set; }
    }
}
