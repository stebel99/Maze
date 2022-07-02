using Maze.DAL.Enums;

namespace Maze.DAL.Entities
{
    public class Cell
    {
        public Guid Id { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public CellType CellType { get; set; }

        public int AreaId { get; set; }

        public Area? Area { get; set; }
    }
}