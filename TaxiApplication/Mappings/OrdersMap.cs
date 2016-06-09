using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaxiApplication.Entities;

namespace TaxiApplication.Mappings
{
    public class OrdersMap : ClassMap<Orders>
    {
        public OrdersMap()
        {
            Id(x => x.OrderID);
            Map(x => x.OrderTrackingNumber);
            Map(x => x.ClientName);
            Map(x => x.Destination_From);
            Map(x => x.Destination_To);
            Map(x => x.PreferredCarTypeName);
            Map(x => x.OnlyThisCarType);
            References(x => x.AssignedDriver);
            Map(x => x.OrderStatus);
        }
    }
}
