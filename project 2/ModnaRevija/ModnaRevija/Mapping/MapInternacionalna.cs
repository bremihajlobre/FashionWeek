using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Mapping
{
    class MapInternacionalna : SubclassMap<ModnaRevija.Enitites.Internacionalna>
    {
        public MapInternacionalna()
        {
            Table("INTERNACIONALNA");

            //Id(x => x.PibAgencija, "PIB_AGENCIJA").GeneratedBy.Assigned();
            KeyColumn("PIB_AGENCIJA");

            HasMany(x => x.Zemlje).KeyColumn("PIB_AGENCIJA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
