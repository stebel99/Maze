using Maze.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Maze.DAL.Repositories
{
    public class Repository : IRepository
    {
        private MazeDbContext Context { get; set; }

        public Repository(MazeDbContext context)
        {
            Context = context;
        }

        public async Task CreateAreaAsync(Area area, CancellationToken ct)
        {
            await Context.AddAsync(area, ct);
        }

        public async Task<ICollection<Area>> GetAllAreasAsync(CancellationToken ct)
        {
            return await Context.Areas
                .Include(x => x.Cells)
                .AsNoTracking()
                .ToListAsync(ct);
        }

        public async Task SaveChangesAsync(CancellationToken ct)
        {
            await Context.SaveChangesAsync(ct);
        }
    }
}