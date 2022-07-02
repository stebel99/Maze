using Maze.DAL;
using Maze.DAL.Repositories;
using Maze.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Maze.WebApi.Extensions
{
    public static class DiExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["Sql:ConnectionString"];
            services.AddDbContext<MazeDbContext>(o => o.UseSqlServer(connectionString));
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
        }

        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DefaultProfiler));
        }
    }
}