namespace Maze.WebApi.Models
{
    public class ListResponse<T> where T : class
    {
        public int Count { get; set; }

        public ICollection<T> List { get; set; }

        public ListResponse(ICollection<T> list)
        {
            List = list;
            Count = list.Count;
        }
    }
}