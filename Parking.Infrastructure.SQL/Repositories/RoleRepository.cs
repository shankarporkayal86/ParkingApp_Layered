using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class RoleRepository : Repository<UserRoles>, IRoleRepository
    {
        public RoleRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<UserRoles> GetRoles()
        {
            return ParkingManagementContext.UserRoles.ToList();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}