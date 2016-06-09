using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaxiApplication.Entities;

namespace TaxiApplication.Mappings
{
    public class CarTypesMap : ClassMap<CarTypes>
    {
        public CarTypesMap()
        {
            Id(x => x.CarTypeID);
            Map(x => x.CarTypeName);
        }
    }
}
