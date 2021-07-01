using FluentNHibernate.Mapping;
using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Mapping
{
    class MapKuce : ClassMap<Kuce>
    {
        public MapKuce()
        {
            Table("KUCE");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S15763.ISEQ$$_257198");

            //Map(x => x.MatbrKreator, "MATBR_KREATOR");
            Map(x => x.Naziv, "NAZIV");

            References(x => x.ModniKreator).Column("MATBR_KREATOR");
        }
    }
}
