using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories;

namespace Parking.Infrastructure.SQL.Repositories
{
    public class RequestDuationTypeRepository : Repository<RequestDurationType>, IRequestDuationTypeRepository
    {
        public RequestDuationTypeRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<RequestDurationType> GetRequestDurationType()
        {
            return ParkingManagementContext.RequestDurationTypes.ToList();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}