using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace HealthService.Web.References
{
    public static class ReferencedAssemblies
    {
        public static Assembly Services
        {
            get { return Assembly.Load("HealthService.Services"); }
        }

        public static Assembly Repositories
        {
            get { return Assembly.Load("HealthService.Data"); }
        }

        public static Assembly Dto
        {
            get
            {
                return Assembly.Load("HealthService.Dto");
            }
        }

        public static Assembly Domain
        {
            get
            {
                return Assembly.Load("HealthService.Core");
            }
        }
    }
}