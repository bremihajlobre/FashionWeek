using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Enitites
{
    public class SpecGost
    {
        public virtual int Id { get; set; }
        //public virtual int IdRevija { get; set; }
        public virtual string ImeGosta { get; set; }
        public virtual string PrezimeGosta { get; set; }
        public virtual string Zanimanje { get; set; }

        public virtual ModnaRevija Gostuje { get; set; }

        public SpecGost()
        {

        }
    }
}
