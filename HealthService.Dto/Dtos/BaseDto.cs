using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.DTO.Dtos
{
    public class BaseDto
    {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}