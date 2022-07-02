using Maze.DAL.Entities;

namespace Maze.DAL.Repositories
{
    public interface IRepository
    {
        Task CreateAreaAsync(Area area, CancellationToken ct);

        Task<ICollection<Area>> GetAllAreasAsync(CancellationToken ct);

        Task SaveChangesAsync(CancellationToken ct);
    }
}