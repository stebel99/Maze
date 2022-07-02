using Maze.DAL.Entities;
using Maze.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Maze.DAL.Extensions
{
    public static class CellExtension
    {
        public static void BuildCell(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cell>(e =>
            {
                e.HasKey(x => x.Id);

                e.Property(x => x.CellType)
                    .HasMaxLength(16)
                    .HasConversion<EnumToStringConverter<CellType>>();
            });
        }
    }
}