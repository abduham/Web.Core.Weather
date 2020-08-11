using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Core.Weather.Models;

namespace Web.Core.Weather.CommonConfiguration
{
    public class Connector : IConnector
    {

        public void ConnectorService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews();

            IServiceCollection serviceCollection = services.AddDbContext<WeatherContext>(options => options.UseSqlServer
            (configuration.GetConnectionString("WeatherConnection")));
            services.AddMvc(options => options.EnableEndpointRouting = false).AddXmlSerializerFormatters();
        }
    }
}
