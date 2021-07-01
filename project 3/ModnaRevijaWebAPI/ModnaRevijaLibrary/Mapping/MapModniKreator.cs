using FluentNHibernate.Mapping;
using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Mapping
{
    class MapModniKreator : SubclassMap<ModniKreator>
    {
        public MapModniKreator()
        {
            Table("MODNI_KREATOR");

            //Id(x => x.Matbr, "MATBR").GeneratedBy.Assigned();

            KeyColumn("MATBR");

            Map(x => x.Zemlja, "ZEMLJA");

            HasMany(x => x.Kuce).KeyColumn("MATBR_KREATOR").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.Revije).KeyColumn("MATBR_KREATOR").LazyLoad().Cascade.All().Inverse();
        }
    }
}
