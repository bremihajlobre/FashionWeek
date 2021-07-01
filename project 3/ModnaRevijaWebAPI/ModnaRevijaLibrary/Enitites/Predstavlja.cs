using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Enitites
{
    public class Predstavlja
    {
        public virtual int Id { get; /* protected */ set; }
        //public virtual int MatbrKreator { get; set; }
        //public virtual int IdRevija { get; set; }
        public virtual string Kolaborirali { get; set; }

        public virtual ModniKreator Kreator { get; set; }
        public virtual ModnaRevija Prezentuje { get; set; }

        public Predstavlja()
        {

        }
    }
}
