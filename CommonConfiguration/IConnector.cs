using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Core.Weather.CommonConfiguration
{
    public interface IConnector
    {
        void ConnectorService(IServiceCollection services, IConfiguration configuration);
    }
}
