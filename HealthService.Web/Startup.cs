using HealthService.Web.Mappings;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;

[assembly: OwinStartup(typeof(HealthService.Web.Startup))]

namespace HealthService.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var mappingDefinitions = new MappingDefinitions();
            mappingDefinitions.Initialise();

            ConfigureAuth(app);
        }
    }
}