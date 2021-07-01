using FluentNHibernate.Mapping;
using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Mapping
{
    class MapPripada : ClassMap<Pripada>
    {
        public MapPripada()
        {
            Table("PRIPADA");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S15763.ISEQ$$_257185");

            Map(x => x.MatbrManeken, "MATBR_MANEKEN");
            Map(x => x.PibAgencija, "PIB_AGENCIJA");
        }
    }
}
