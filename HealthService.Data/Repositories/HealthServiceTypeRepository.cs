using HealthService.Core;
using HealthService.Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Data.Repositories
{
    public class HealthServiceTypeRepository : BaseRepository<HealthServiceType>, IHealthServiceTypeRepository
    {
        public HealthServiceTypeRepository(IDbContext context) : base(context)
        {
        }
    }
}