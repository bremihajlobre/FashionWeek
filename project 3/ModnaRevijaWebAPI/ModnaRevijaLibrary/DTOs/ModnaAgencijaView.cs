using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class ModnaAgencijaView
    {
        public int Pib { get; set; }
        public string NazivAgencije { get; set; }
        public string Sediste { get; set; }
        public DateTime DatumOsnivanja { get; set; }
        public virtual IList<ManekenView> Manekeni { get; set; }

        public ModnaAgencijaView()
        {
            Manekeni = new List<ManekenView>();
        }

        public ModnaAgencijaView(ModnaAgencija ma)
        {
            Pib = ma.Pib;
            NazivAgencije = ma.NazivAgencije;
            Sediste = ma.Sediste;
            DatumOsnivanja = ma.DatumOsnivanja;
        }
    }
}
