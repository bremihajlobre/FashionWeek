using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Enitites
{
    public class Internacionalna : ModnaAgencija
    {
        //public virtual int PibAgencija { get; set; }

        public virtual IList<Zemlje> Zemlje { get; set; }

        public Internacionalna()
        {
            Zemlje = new List<Zemlje>();
        }
    }
}
