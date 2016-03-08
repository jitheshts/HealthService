using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthService.Core.Entities.Foundation
{
    public interface IEntity
    {
        long Id { get; set; }

        bool IsDeleted { get; set; }
    }
}