using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevija.Mapping
{
    class MapModnaAgencija : ClassMap<ModnaRevija.Enitites.ModnaAgencija>
    {
        public MapModnaAgencija()
        {
            Table("MODNA_AGENCIJA");

            Id(x => x.Pib, "PIB").GeneratedBy.Assigned();

            Map(x => x.NazivAgencije, "NAZIV_AGENCIJE");
            Map(x => x.Sediste, "SEDISTE");
            Map(x => x.DatumOsnivanja, "DATUM_OSNIVANJA");

            HasManyToMany(x => x.Manekeni)
                .Table("PRIPADA")
                .ParentKeyColumn("PIB_AGENCIJA")
                .ChildKeyColumn("MATBR_MANEKEN")
                .Cascade.All().Inverse();
        }
    }
}
