using FluentNHibernate.Mapping;
using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Mapping
{
    class MapManeken : SubclassMap<Maneken>
    {
        public MapManeken()
        {
            Table("MANEKEN");

            //Id(x => x.Matbr, "MATBR").GeneratedBy.Assigned();
            KeyColumn("MATBR");

            Map(x => x.BojaOciju, "BOJA_OCIJU");
            Map(x => x.BojaKose, "BOJA_KOSE");
            Map(x => x.KonfBroj, "KONFBROJ");
            Map(x => x.Visina, "VISINA");
            Map(x => x.Tezina, "TEZINA");

            HasMany(x => x.Casopisi).KeyColumn("MATBR_MANEKEN").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.ModneRevije)
                .Table("NASTUPA")
                .ParentKeyColumn("MATBR_MANEKEN")
                .ChildKeyColumn("ID_REVIJA")
                .Cascade.All();

            HasManyToMany(x => x.ModneAgencije)
                .Table("PRIPADA")
                .ParentKeyColumn("MATBR_MANEKEN")
                .ChildKeyColumn("PIB_AGENCIJA")
                .Cascade.All();
        }
    }
}
