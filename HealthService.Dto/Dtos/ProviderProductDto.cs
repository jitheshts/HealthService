using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.DTO.Dtos
{
    public class ProviderProductDto : BaseDto
    {
        public ProviderProductDto()
        {
        }

        public long HealthServiceProviderID { get; set; }

        public string ProductName { get; set; }
        public string PriceRange { get; set; }
    }
}