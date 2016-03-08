using HealthService.Core;
using HealthService.Core.Data;
using HealthService.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Services.Services
{
    public class HealthServiceProviderService : BaseService<HealthServiceProvider>, IHealthServiceProviderService
    {
        public HealthServiceProviderService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}