namespace Maze.DAL.Entities
{
    public class Area
    {
        public int Id { get; set; }

        public int SizeCell { get; set; }

        public ICollection<Cell>? Cells { get; set; }
    }
}