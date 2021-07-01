using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Enitites
{
    public class Nastupa
    {
        public virtual int Id { get; /* protected */ set; }
        public virtual int MatbrManeken { get; set; }
        public virtual int IdRevija { get; set; }
    }
}
