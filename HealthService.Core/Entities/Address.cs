using HealthService.Core.Entities.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Core.Entities
{
    public class Address : BaseEntity
    {
        public Address()
        {
        }

        public virtual HealthServiceProvider HealthServiceProvider { get; set; }

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