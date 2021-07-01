using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class PripadaView
    {
        public int Id { get; /* protected */ set; }
        public int MatbrManeken { get; set; }
        public int PibAgencija { get; set; }

        public PripadaView()
        {

        }

        public PripadaView(Pripada p)
        {
            Id = p.Id;
            MatbrManeken = p.MatbrManeken;
            PibAgencija = p.PibAgencija;
        }
    }
}
