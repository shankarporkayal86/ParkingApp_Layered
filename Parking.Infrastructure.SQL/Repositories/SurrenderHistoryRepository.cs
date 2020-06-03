﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class SurrenderHistoryRepository : Repository<SurrenderHistory>, ISurrenderHistoryRepository
    {
        public SurrenderHistoryRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<SurrenderHistory> GetSurrenderHistories()
        {
            return ParkingManagementContext.SurrenderHistories.ToList();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}