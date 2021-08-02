using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SquaresSolution.Domain.Entities;
using SquaresSolution.Domain.Services;
using SquaresSolution.Infrostructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SquaresSolution.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PointsController : ControllerBase
    {
        private readonly PointsService _service;

        public PointsController(PointsService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PointEntity>>> GetAll()
        {
            var points = await _service.GetAll();

            return Ok(points);
        }
    }
}
