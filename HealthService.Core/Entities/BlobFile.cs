using HealthService.Core.Entities.Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthService.Core
{
    public class BlobFile : BaseEntity
    {
        public BlobFile()
        {
        }

        public long HealthServiceProviderID { get; set; }

        public virtual HealthServiceProvider HealthServiceProvider { get; set; }

        public byte[] Content { get; set; }

        public int Order { get; set; }
    }
}