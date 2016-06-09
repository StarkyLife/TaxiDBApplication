using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaxiApplication.Entities;

namespace TaxiApplication.Mappings
{
    public class DriversViewMap : ClassMap<DriversView>
    {
        public DriversViewMap()
        {
            Table("DriversView");
            ReadOnly();
            Id(x => x.DriverID);
            Map(x => x.DriverName);
            Map(x => x.CarTypeName);
            Map(x => x.CarColor);
            Map(x => x.CarNumber);
            Map(x => x.Available);
        }
    }
}
