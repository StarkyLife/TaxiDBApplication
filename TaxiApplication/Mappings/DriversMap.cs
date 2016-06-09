using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaxiApplication.Entities;

namespace TaxiApplication.Mappings
{
    public class DriversMap : ClassMap<Drivers>
    {
        public DriversMap()
        {
            Id(x => x.DriverID);
            Map(x => x.DriverName);
            References(x => x.Car);
            Map(x => x.Available);
        }
    }
}
