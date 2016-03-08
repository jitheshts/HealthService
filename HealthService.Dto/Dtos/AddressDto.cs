using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.DTO.Dtos
{
    public class AddressDto : BaseDto
    {
        public AddressDto()
        {
        }

        public long HealthServiceProviderID { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Street { get; set; }
        public string CityCode { get; set; }
        public string StateCode { get; set; }
        public string PostCode { get; set; }
        public string CountryCode { get; set; }
    }
}