﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories;
using System.Data.Entity;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class SlotRequestDetailsRepository : Repository<SlotRequestDeatils>, ISlotRequestDetailsRepository
    {
        public SlotRequestDetailsRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<SlotRequestDeatils> GetSlotRequestDeatils()
        {
            return ParkingManagementContext.SlotRequestDeatils
                .Include(c=>c.RequestDurationType)
                .Include(c=>c.Tower)
                .Include(c=>c.TowerBlock)
                .Include(c=>c.TowerBlock)
                .Include(c=>c.Registers)
                .ToList();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}