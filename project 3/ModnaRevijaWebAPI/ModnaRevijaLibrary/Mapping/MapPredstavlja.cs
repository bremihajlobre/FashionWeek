using FluentNHibernate.Mapping;
using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Mapping
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

            References(x => x.Prezentuje).Column("ID_REVIJA").Cascade.All();

            References(x => x.Kreator).Column("MATBR_KREATOR").Cascade.All();
        }
    }
}
