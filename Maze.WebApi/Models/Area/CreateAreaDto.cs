using Maze.WebApi.Models.Cell;

namespace Maze.WebApi.Models.Area
{
    public class CreateAreaDto
    {
        public int SizeCell { get; set; }

        public ICollection<CreateCellDto> Cells { get; set; }
    }
}