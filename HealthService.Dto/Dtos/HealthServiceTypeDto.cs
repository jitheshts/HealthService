using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.DTO.Dtos
{
    public class HealthServiceTypeDto : BaseDto
    {
        public HealthServiceTypeDto()
        {
        }

        public string MainCategory { get; set; }

        public string SubCategory { get; set; }

        public byte[] Logo { get; set; }

        public List<HealthServiceProviderDto> HealthServiceProviders { get; set; }
    }
}