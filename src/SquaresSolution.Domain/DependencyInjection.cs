using Microsoft.Extensions.DependencyInjection;
using SquaresSolution.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresSolution.Domain
{
    public static class DependencyInjection
    {
        public static void RegisterDomainService(this IServiceCollection services)
        {
            services.AddScoped<PointsService>();
        }
    }
}
