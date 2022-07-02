using Maze.WebApi.Models.Cell;

namespace Maze.WebApi.Models.Area
{
    public class GetAreaDto
    {
        public int Id { get; set; }

        public int SizeCell { get; set; }

        public ICollection<GetCellDto>? Cells { get; set; }
    }
}