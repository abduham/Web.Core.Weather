using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Core.Weather.CommonConfiguration
{
    public static class ConnectorExcution
    {
        public static void ConnectionServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes.Where(x =>

                typeof(IConnector).IsAssignableFrom(x) && !x.IsAbstract && !x.IsInterface).Select(Activator.CreateInstance).Cast<IConnector>().ToList();
            installers.ForEach(installer => installer.ConnectorService(services, configuration));
        }
    }
}
