using HealthService.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Data.Configurations
{
    public class BlobFileConfiguration : EntityTypeConfiguration<BlobFile>
    {
        public BlobFileConfiguration()
        {
            Property(c => c.Content).IsRequired();
        }
    }
}