using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class TowerBlockSlotRepository : Repository<TowerBlockSlot>, ITowerBlockSlotRepository
    {
        public TowerBlockSlotRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<TowerBlockSlot> GetTowerBlockSlots()
        {
            return ParkingManagementContext.TowerBlockSlots.ToList();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}