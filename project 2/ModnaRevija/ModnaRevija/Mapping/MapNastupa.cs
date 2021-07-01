using FluentNHibernate.Mapping;
using ModnaRevija.Enitites;
using NHibernate.Linq.ResultOperators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Mapping
{
    class MapNastupa : ClassMap<Nastupa>
    {
        public MapNastupa()
        {
            Table("NASTUPA");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S15763.ISEQ$$_257179");

            Map(x => x.IdRevija, "ID_REVIJA");
            Map(x => x.MatbrManeken, "MATBR_MANEKEN");
        }
    }
}
