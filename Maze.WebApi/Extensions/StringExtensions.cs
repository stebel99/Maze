using System.Text.Json;

namespace Maze.WebApi.Extensions
{
    public static class StringExtensions
    {
        public static string ToJson(this object baseObject)
        {
            return JsonSerializer.Serialize(baseObject);
        }
    }
}