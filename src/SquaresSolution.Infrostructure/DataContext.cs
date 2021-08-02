using Microsoft.EntityFrameworkCore;
using SquaresSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresSolution.Infrostructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PointEntity>()
                .HasKey(p => new { p.X, p.Y });
        }

        public DbSet<PointEntity> Points { get; set; }

    }
}
