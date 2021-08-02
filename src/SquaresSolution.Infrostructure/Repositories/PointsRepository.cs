using Microsoft.EntityFrameworkCore;
using SquaresSolution.Domain.Entities;
using SquaresSolution.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SquaresSolution.Infrostructure.Repositories
{
    public class PointsRepository : IPointsRepository
    {
        private readonly DataContext _context;

        public PointsRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public async Task<IEnumerable<PointEntity>> GetAll()
        {
            var points = await _context.Points.ToListAsync();

            return points;
        }

        public async Task AddPoint(PointEntity point)
        {
            _context.Add(point);

            await _context.SaveChangesAsync();
        }
    }
}
