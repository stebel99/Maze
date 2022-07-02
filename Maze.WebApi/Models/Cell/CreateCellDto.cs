using Maze.DAL.Enums;

namespace Maze.WebApi.Models.Cell
{
    public class CreateCellDto
    {
        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public CellType CellType { get; set; }
    }
}