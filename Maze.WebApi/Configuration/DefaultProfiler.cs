using AutoMapper;
using Maze.DAL.Entities;
using Maze.WebApi.Models.Area;
using Maze.WebApi.Models.Cell;

namespace Maze.WebApi.Configuration
{
    public class DefaultProfiler : Profile
    {
        public DefaultProfiler()
        {
            CreateMap<CreateCellDto, Cell>();
            CreateMap<CreateAreaDto, Area>();

            CreateMap<Cell, GetCellDto>();
            CreateMap<Area, GetAreaDto>();
        }
    }
}