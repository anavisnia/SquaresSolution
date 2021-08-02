using SquaresSolution.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SquaresSolution.Domain.Interfaces
{
    public interface IPointsRepository
    {
        Task<IEnumerable<PointEntity>> GetAll();
        Task AddPoint(PointEntity point);
    }
}