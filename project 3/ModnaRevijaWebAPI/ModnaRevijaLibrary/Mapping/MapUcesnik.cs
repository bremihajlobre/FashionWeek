using FluentNHibernate.Mapping;
using ModnaRevijaLibrary.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModnaRevijaLibrary.Mapping
{
    class MapUcesnik : ClassMap<ModnaRevijaLibrary.Enitites.Ucesnik>
    {
        public MapUcesnik()
        {
            Table("Ucesnik");

            Id(x => x.MatBr, "MATBR").GeneratedBy.Assigned();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Pol, "POL");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
        }
    }
}
