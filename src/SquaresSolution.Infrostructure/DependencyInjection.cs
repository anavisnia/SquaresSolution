using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SquaresSolution.Domain.Interfaces;
using SquaresSolution.Infrostructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresSolution.Infrostructure
{
    public static class DependencyInjection
    {
        public static void RegisterDataContext(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(c => c.UseSqlServer(defaultConnection));

            services.AddScoped<IPointsRepository, PointsRepository>();
        }
    }
}
