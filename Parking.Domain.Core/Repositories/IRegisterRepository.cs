using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parking.Domain.Core.Entities;

namespace Parking.Domain.Core.Repositories
{
    public interface IRegisterRepository : IRepository<Registers>
    {
        IEnumerable<Registers> GetRegisters(int Id);
        Registers ValidateLogin(Registers LoginDetails);
    }
}