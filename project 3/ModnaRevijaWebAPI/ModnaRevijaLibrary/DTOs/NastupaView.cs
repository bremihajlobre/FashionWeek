using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class NastupaView
    {
        public int Id { get; /* protected */ set; }
        public int MatbrManeken { get; set; }
        public int IdRevija { get; set; }

        public NastupaView()
        {
        }

        public NastupaView(Nastupa n)
        {
            Id = n.Id;
            MatbrManeken = n.MatbrManeken;
            IdRevija = n.IdRevija;
        }
    }
}
