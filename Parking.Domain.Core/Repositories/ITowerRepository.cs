﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Domain.Core.Entities;


namespace Parking.Domain.Core.Repositories
{
    public interface ITowerRepository : IRepository<Tower>
    {
        IEnumerable<Tower> GetTowers();
    }
}