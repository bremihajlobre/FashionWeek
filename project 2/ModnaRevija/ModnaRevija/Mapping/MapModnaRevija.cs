using FluentNHibernate.Mapping;
using FluentNHibernate.Utils;
using ModnaRevija.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Mapping
{
    class MapModnaRevija : ClassMap<ModnaRevija.Enitites.ModnaRevija>
    {
        public MapModnaRevija()
        {
            Table("MODNA_REVIJA");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S15763.ISEQ$$_257151");

            Map(x => x.Rbr, "RBR");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Mesto, "MESTO");
            Map(x => x.DatumVremeOdrzavanja, "DATUMVREME_ODRZAVANJA");

            HasMany(x => x.SpecijalniGosti).KeyColumn("ID_REVIJA").Cascade.All().Inverse();

            HasManyToMany(x => x.Manekeni)
                .Table("NASTUPA")
                .ParentKeyColumn("ID_REVIJA")
                .ChildKeyColumn("MATBR_MANEKEN")
                .Cascade.All().Inverse();

            HasMany(x => x.MKreatorNaMReviji).KeyColumn("ID_REVIJA").Cascade.All().Inverse();
        }
    }
}
