using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class InternacionalnaView : ModnaAgencijaView
    {
        public IList<ZemljeView> Zemlje { get; set; }
        public InternacionalnaView()
        {
            Zemlje = new List<ZemljeView>();
        }

        public InternacionalnaView (Internacionalna i) : base(i)
        {
        }
    }
}
