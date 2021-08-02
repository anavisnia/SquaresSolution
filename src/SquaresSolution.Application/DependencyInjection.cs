using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SquaresSolution.Domain;
using SquaresSolution.Infrostructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresSolution.Application
{
    public static class DependencyInjection
    {
        public static void ConfigureApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDomainService();
            services.RegisterDataContext(configuration);
        }
    }
}
