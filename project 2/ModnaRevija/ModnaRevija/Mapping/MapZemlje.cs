using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Mapping
{
    class MapZemlje : ClassMap<ModnaRevija.Enitites.Zemlje>
    {
        public MapZemlje()
        {
            Table("ZEMLJE");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S15763.ISEQ$$_257204");

           // Map(x => x.PibAgencija, "PIB_AGENCIJA");
            Map(x => x.Naziv, "NAZIV");

            References(x => x.InternacionalnaMAgencija).Column("PIB_AGENCIJA").LazyLoad();
        }
    }
}
