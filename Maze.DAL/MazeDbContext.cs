using Maze.DAL.Entities;
using Maze.DAL.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Maze.DAL
{
    public class MazeDbContext : DbContext
    {
        public DbSet<Area>? Areas { get; set; }

        public DbSet<Cell>? Cells { get; set; }

        public MazeDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KH0631\MSSQLSERVERLOCAL;Database=MazeDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.BuildArea();
            modelBuilder.BuildCell();
        }
    }
}