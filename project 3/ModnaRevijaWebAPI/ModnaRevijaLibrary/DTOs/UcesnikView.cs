using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class UcesnikView
    {
        public int MatBr { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pol { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public UcesnikView()
        {
        }

        public UcesnikView(Ucesnik u)
        {
            MatBr = u.MatBr;
            Ime = u.Ime;
            Prezime = u.Prezime;
            Pol = u.Pol;
            DatumRodjenja = u.DatumRodjenja;
        }
    }
}
