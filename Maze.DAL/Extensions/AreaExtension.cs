using Maze.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Maze.DAL.Extensions
{
    public static class AreaExtension
    {
        public static void BuildArea(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(e =>
            {
                e.HasKey(x => x.Id);
            });
        }
    }
}