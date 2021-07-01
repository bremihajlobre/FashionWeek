using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using ModnaRevija.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Mapping
{
    class MapCasopisi : ClassMap<Casopisi>
    {
        public MapCasopisi()
        {
            Table("CASOPISI");

            Id(x => x.Id, "ID").GeneratedBy.Sequence("S15763.ISEQ$$_257201");

            //Map(x => x.MatbrManeken, "MATBR_MANEKEN");
            Map(x => x.Naziv, "NAZIV");

            References(x => x.Maneken).Column("MATBR_MANEKEN");
        }

    }
}
