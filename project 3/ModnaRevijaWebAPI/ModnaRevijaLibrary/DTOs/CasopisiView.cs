using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class CasopisiView
    {
        public int Id { get; protected set; }
        public string Naziv { get; set; }
        public ManekenView Maneken { get; set; }

        public CasopisiView()
        {
        }

        public CasopisiView(Casopisi c)
        {
            Id = c.Id;
            Naziv = c.Naziv;
            Maneken = new ManekenView(c.Maneken);
        }
    }
}
