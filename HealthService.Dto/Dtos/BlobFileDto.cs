using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.DTO.Dtos
{
    public class BlobFileDto : BaseDto
    {
        public BlobFileDto()
        {
        }

        public long HealthServiceProviderID { get; set; }

        public byte[] Content { get; set; }

        public int Order { get; set; }
    }
}