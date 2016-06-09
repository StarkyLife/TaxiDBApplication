using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaxiApplication.Entities;

namespace TaxiApplication.Mappings
{
    public class CarsMap : ClassMap<Cars>
    {
        public CarsMap()
        {
            Id(x => x.CarID);
            References(x => x.CarType);
            Map(x => x.CarColor);
            Map(x => x.CarNumber);
        }
    }
}
