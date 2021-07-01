using FluentNHibernate.Mapping;
using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Mapping
{
    class MapSpecGost : ClassMap<SpecGost>
    {
        public MapSpecGost()
        {
            Table("SPEC_GOST");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S15763.ISEQ$$_257173");

            //Map(x => x.IdRevija, "ID_REVIJA");
            Map(x => x.ImeGosta, "IME_GOSTA");
            Map(x => x.PrezimeGosta, "PREZIME_GOSTA");
            Map(x => x.Zanimanje, "ZANIMANJE");

            References(x => x.Gostuje).Column("ID_REVIJA").LazyLoad();
        }
    }
}
