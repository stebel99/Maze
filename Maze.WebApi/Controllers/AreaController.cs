using Maze.DAL.Repositories;
using Maze.WebApi.Extensions;
using Maze.WebApi.Models.Area;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using AutoMapper;
using Maze.DAL.Entities;
using Maze.WebApi.Models;

namespace Maze.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AreaController : Controller
    {
        private readonly ILogger<AreaController> _logger;
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public AreaController(ILogger<AreaController> logger, IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> CreateAreaAsync(CreateAreaDto areaDto, CancellationToken ct)
        {
            _logger.LogInformation("CreateAreaAsync was triggered with parameter:{Area}", areaDto.ToJson());
            if (areaDto is null)
            {
                return BadRequest();
            }

            Area area = _mapper.Map<Area>(areaDto);

            await _repository.CreateAreaAsync(area, ct);
            await _repository.SaveChangesAsync(ct);

            return Ok(area);
        }

        [HttpGet]
        public async Task<IActionResult> GetAreasAsync(CancellationToken ct)
        {
            _logger.LogInformation("GetAreasAsync was triggered");
            ICollection<Area> areas = await _repository.GetAllAreasAsync(ct);

            if (!areas.Any())
            {
                return NotFound();
            }

            ICollection<GetAreaDto> resultAreas = _mapper.Map<ICollection<GetAreaDto>>(areas);

            ListResponse<GetAreaDto> response = new(resultAreas);

            return Ok(response);
        }
    }
}