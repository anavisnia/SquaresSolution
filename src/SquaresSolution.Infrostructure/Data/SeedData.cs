using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresSolution.Infrostructure.Data
{
    public static class SeedData
    {
        public static async Task Initialize(this IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DataContext>();

            context.Points.Add(new Domain.Entities.PointEntity()
            {
                X = 0,
                Y = 0
            });

            await context.SaveChangesAsync();
        }
    }
}
