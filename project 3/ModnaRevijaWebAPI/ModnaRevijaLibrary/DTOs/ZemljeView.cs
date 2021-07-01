using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class ZemljeView
    {
        public int Id { get; protected set; }
        public int PibAgencija { get; set; }
        public string Naziv { get; set; }

        public InternacionalnaView InternacionalnaMAgencija { get; set; }

        public ZemljeView()
        {
        }

        public ZemljeView(Zemlje z)
        {
            Id = z.Id;
            PibAgencija = z.PibAgencija;
            Naziv = z.Naziv;
            InternacionalnaMAgencija = new InternacionalnaView(z.InternacionalnaMAgencija);
        }
    }
}
