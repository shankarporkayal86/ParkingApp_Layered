﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class RequestDetailsRepository : Repository<RequestDetails>, IRequestDetailsRepository
    {
        public RequestDetailsRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<RequestDetails> GetRequestDetails()
        {
            return ParkingManagementContext.RequestDetails
                .Include(c=>c.RequestDurationType)
                .Include(c=>c.Registers).ToList();
        }
        public IEnumerable<RequestDetails> GetPatientsApi()
        {
            return ParkingManagementContext.RequestDetails.Include(c => c.Registers).Include(c=>c.RequestDurationType);
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}