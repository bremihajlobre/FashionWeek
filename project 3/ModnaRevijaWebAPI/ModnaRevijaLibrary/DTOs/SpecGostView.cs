using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class SpecGostView
    {
        public int Id { get; set; }
        public string ImeGosta { get; set; }
        public string PrezimeGosta { get; set; }
        public string Zanimanje { get; set; }
        public  ModnaRevijaView Gostuje { get; set; }
        public SpecGostView()
        {
        }

        public SpecGostView(SpecGost sg)
        {
            Id = sg.Id;
            ImeGosta = sg.ImeGosta;
            PrezimeGosta = sg.PrezimeGosta;
            Zanimanje = sg.Zanimanje;
            Gostuje = new ModnaRevijaView(sg.Gostuje);
        }
    }
}
