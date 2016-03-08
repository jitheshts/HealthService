using HealthService.Core.Entities.Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthService.Core
{
    public class ProviderProduct : BaseEntity
    {
        public ProviderProduct()
        {
        }

        public virtual HealthServiceProvider HealthServiceProvider { get; set; }

        public long HealthServiceProviderID { get; set; }

        public string ProductName { get; set; }
        public string PriceRange { get; set; }
    }
}