using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class KuceView
    {
        public int Id { get; protected set; }
        public string Naziv { get; set; }
        public ModniKreatorView ModniKreator { get; set; }

        public KuceView()
        {
        }

        public KuceView(Kuce k)
        {
            Id = k.Id;
            Naziv = k.Naziv;
            ModniKreator = new ModniKreatorView(k.ModniKreator);
        }
    }
}
