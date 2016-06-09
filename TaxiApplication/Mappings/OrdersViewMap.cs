using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaxiApplication.Entities;

namespace TaxiApplication.Mappings
{
    public class OrdersViewMap : ClassMap<OrdersView>
    {
        public OrdersViewMap()
        {
            Table("OrdersView");
            ReadOnly();
            Map(x => x.CompanyID);
            Map(x => x.OrderID);
            Id(x => x.OrderTrackingNumber);
            Map(x => x.ClientName);
            Map(x => x.Destination_From);
            Map(x => x.Destination_To);
            Map(x => x.PreferredCarTypeName);
            Map(x => x.OnlyThisCarType);
            Map(x => x.DriverID);
            Map(x => x.DriverName);
            Map(x => x.CarTypeName);
            Map(x => x.CarColor);
            Map(x => x.CarNumber);
            Map(x => x.OrderStatus);
        }
    }
}
