using HealthService.Core.Entities.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthService.Core
{
    public class HealthServiceType : BaseEntity
    {
        public HealthServiceType()
        {
            HealthServiceProviders = new List<HealthServiceProvider>();
        }

        public string MainCategory { get; set; }

        public string SubCategory { get; set; }

        public byte[] Logo { get; set; }

        public ICollection<HealthServiceProvider> HealthServiceProviders { get; set; }
    }
}