using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Enitites
{
    public class Maneken : Ucesnik
    {
        //public virtual int Matbr { get; set; }
        public virtual string BojaOciju { get; set; }
        public virtual string BojaKose { get; set; }
        public virtual int KonfBroj { get; set; }
        public virtual int Visina { get; set; }
        public virtual int Tezina { get; set; }

        public virtual IList<Casopisi> Casopisi { get; set; }

        public virtual IList<ModnaRevija> ModneRevije { get; set; }

        public virtual IList<ModnaAgencija> ModneAgencije { get; set; }

        public Maneken()
        {
            Casopisi = new List<Casopisi>();
            ModneRevije = new List<ModnaRevija>();
            ModneAgencije = new List<ModnaAgencija>();
        }
    }
}
