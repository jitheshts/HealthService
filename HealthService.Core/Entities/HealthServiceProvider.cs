using HealthService.Core.Entities;
using HealthService.Core.Entities.Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthService.Core
{
    public class HealthServiceProvider : BaseEntity
    {
        public HealthServiceProvider()
        {
            ProviderProducts = new List<ProviderProduct>();
            BlobFiles = new List<BlobFile>();
        }

        public virtual Address Address { get; set; }

        public long AddressID { get; set; }

        public string ProviderName { get; set; }

        public string OpeningHours { get; set; }

        public virtual HealthServiceType HealthServiceType { get; set; }

        public long HealthServiceTypeID { get; set; }

        public ICollection<ProviderProduct> ProviderProducts { get; set; }

        public ICollection<BlobFile> BlobFiles { get; set; }
    }
}