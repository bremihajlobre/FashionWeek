using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class PredstavljaView
    {
        public int Id { get; /* protected */ set; }
        public string Kolaborirali { get; set; }
        //public string NazivRevije { get; set; }

        public ModniKreatorView Kreator { get; set; }
        public ModnaRevijaView Prezentuje { get; set; }

        public PredstavljaView()
        {
        }

        public PredstavljaView(Predstavlja p)
        {
            Kreator = new ModniKreatorView(p.Kreator);
            Prezentuje = new ModnaRevijaView(p.Prezentuje);
        }

    }
}
