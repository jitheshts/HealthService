using HealthService.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Data.Configurations
{
    public class ProviderProductConfiguration : EntityTypeConfiguration<ProviderProduct>
    {
        public ProviderProductConfiguration()
        {
            Property(c => c.ProductName).IsRequired();
        }
    }
}