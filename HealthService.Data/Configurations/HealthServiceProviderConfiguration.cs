using HealthService.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Data.Configurations
{
    public class HealthServiceProviderConfiguration : EntityTypeConfiguration<HealthServiceProvider>
    {
        public HealthServiceProviderConfiguration()
        {
            Property(c => c.ProviderName).IsRequired();

            HasMany(d => d.BlobFiles).
            WithRequired(c => c.HealthServiceProvider).
            HasForeignKey(c => c.HealthServiceProviderID);

            HasMany(d => d.ProviderProducts).
            WithRequired(c => c.HealthServiceProvider).
            HasForeignKey(c => c.HealthServiceProviderID);
        }
    }
}