using Maze.DAL.Enums;

namespace Maze.WebApi.Models.Cell
{
    public class GetCellDto
    {
        public Guid Id { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public CellType CellType { get; set; }
    }
}