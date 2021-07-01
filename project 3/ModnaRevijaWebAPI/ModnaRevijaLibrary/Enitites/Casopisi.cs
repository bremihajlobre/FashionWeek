using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Enitites
{
    public class Casopisi
    {
        public virtual int Id { get; protected set; }
        //public virtual int MatbrManeken { get; set; }
        public virtual string Naziv { get; set; }

        public virtual Maneken Maneken { get; set; }
    }
}
