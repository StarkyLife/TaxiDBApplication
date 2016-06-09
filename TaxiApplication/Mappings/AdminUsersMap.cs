using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaxiApplication.Entities;

namespace TaxiApplication.Mappings
{
    public class AdminUsersMap : ClassMap<AdminUsers>
    {
        public AdminUsersMap()
        {
            Id(x => x.id);
            Map(x => x.userName);
            Map(x => x.userPassword);
        }
    }
}
