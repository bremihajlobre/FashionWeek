using FluentNHibernate.Mapping;
using ModnaRevija.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Mapping
{
    class MapPredstavlja : ClassMap<Predstavlja>
    {
        public MapPredstavlja()
        {
            Table("PREDSTAVLJA");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S15763.ISEQ$$_257176");

            //Map(x => x.MatbrKreator, "MATBR_KREATOR");
           // Map(x => x.IdRevija, "ID_REVIJA");
            Map(x => x.Kolaborirali, "KOLABORIRALI");

            References(x => x.ModnaRevija).Column("ID_REVIJA").Cascade.All();

            References(x => x.ModniKreator).Column("MATBR_KREATOR").Cascade.All();
        }
    }
}
