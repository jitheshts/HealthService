using HealthService.Core;
using HealthService.Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Data.Repositories
{
    public class HealthServiceProviderRepository : BaseRepository<HealthServiceProvider>, IHealthServiceProviderRepository
    {
        public HealthServiceProviderRepository(IDbContext context) : base(context)
        {
        }
    }
}