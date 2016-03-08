using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.DTO.Dtos
{
    public class HealthServiceProviderDto : BaseDto
    {
        public HealthServiceProviderDto()
        {
        }

        public long AddressID { get; set; }

        public string ProviderName { get; set; }

        public string OpeningHours { get; set; }

        public long HealthServiceTypeID { get; set; }

        public List<BlobFileDto> BlobFiles { get; set; }
        public List<ProviderProductDto> ProviderProducts { get; set; }
    }
}