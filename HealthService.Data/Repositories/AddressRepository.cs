using HealthService.Core.Data.Repositories;
using HealthService.Core.Entities;
using HealthService.Core.Entities.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Data.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(IDbContext context) : base(context)
        {
        }
    }
}