using HealthService.Core.Data;
using HealthService.Core.Entities;
using HealthService.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Services.Services
{
    public class AddressService : BaseService<Address>, IAddressService
    {
        public AddressService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}