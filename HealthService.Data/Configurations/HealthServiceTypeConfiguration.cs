using HealthService.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Data.Configurations
{
    public class HealthServiceTypeConfiguration : EntityTypeConfiguration<HealthServiceType>
    {
        public HealthServiceTypeConfiguration()
        {
            Property(c => c.Logo).IsRequired();
            Property(c => c.MainCategory).IsRequired();

            HasMany(d => d.HealthServiceProviders).
            WithRequired(c => c.HealthServiceType).
            HasForeignKey(c => c.HealthServiceTypeID);
        }
    }
}