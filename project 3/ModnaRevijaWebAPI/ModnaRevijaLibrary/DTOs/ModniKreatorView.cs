using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class ModniKreatorView : UcesnikView
    {
        public string Zemlja { get; set; }
        public virtual IList<KuceView> Kuce { get; set; }
        public  IList<PredstavljaView> Revije { get; set; }

        public ModniKreatorView()
        {
            Revije = new List<PredstavljaView>();
            Kuce = new List<KuceView>();
        }

        public ModniKreatorView(ModniKreator mk) : base(mk)
        {
            Zemlja = mk.Zemlja;
        }
    }
}
