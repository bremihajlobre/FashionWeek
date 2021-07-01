using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModnaRevijaLibrary.DTOs
{
    public class ManekenView : UcesnikView
    {
        public string BojaOciju { get; set; }
        public string BojaKose { get; set; }
        public int KonfBroj { get; set; }
        public int Visina { get; set; }
        public int Tezina { get; set; }

        public IList<CasopisiView> Casopisi { get; set; }
        public IList<ModnaRevijaView> ModneRevije { get; set; }
        public IList<ModnaAgencijaView> ModneAgencije { get; set; }

        public ManekenView()
        {
            ModneRevije = new List<ModnaRevijaView>();
            ModneAgencije = new List<ModnaAgencijaView>();
            Casopisi = new List<CasopisiView>();
        }

        public ManekenView(Maneken m) : base(m)
        {
            BojaOciju = m.BojaOciju;
            BojaKose = m.BojaKose;
            KonfBroj = m.KonfBroj;
            Visina = m.Visina;
            Tezina = m.Tezina;
        }
    }
}
