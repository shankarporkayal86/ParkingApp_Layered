using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class TowerRepository : Repository<Tower>, ITowerRepository
    {
        public TowerRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<Tower> GetTowers()
        {
            return ParkingManagementContext.Towers.ToList();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}