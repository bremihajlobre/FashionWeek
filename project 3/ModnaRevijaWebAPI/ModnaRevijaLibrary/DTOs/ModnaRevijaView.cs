using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class ModnaRevijaView
    {
        public int Id { get; protected set; }
        public int Rbr { get; set; }
        public string Naziv { get; set; }
        public string Mesto { get; set; }
        public DateTime DatumVremeOdrzavanja { get; set; }

        public ModnaRevijaView()
        {
        }

        public ModnaRevijaView(ModnaRevija mr)
        {
            Id = mr.Id;
            Rbr = mr.Rbr;
            Naziv = mr.Naziv;
            Mesto = mr.Mesto;
            DatumVremeOdrzavanja = mr.DatumVremeOdrzavanja;
        }
    }
}
