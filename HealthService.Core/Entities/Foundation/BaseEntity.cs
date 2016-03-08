using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Core.Entities.Foundation
{
    public abstract class BaseEntity : IEntity
    {
        public long Id { get; set; }

        public bool IsDeleted { get; set; }
    }
}