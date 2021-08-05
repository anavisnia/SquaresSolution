using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SquaresSolution.Domain.Entities;
using SquaresSolution.Domain.Exceptions;
using SquaresSolution.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SquaresSolution.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PointsController : ControllerBase
    {
        private readonly IPointsRepository _repository;
        //private readonly PointsService _service;

        public PointsController(IPointsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PointEntity>>> GetAll()
        {
            var points = await _repository.GetAll();

            return Ok(points);
        }

        [HttpPost]
        public async Task<ActionResult> AddPoint(PointEntity point)
        {
            try
            {
                await _repository.AddPoint(point);
            }
            catch (DbUpdateException)
            {

                return BadRequest("The point already exists");
            }
            catch (CustomValidationException ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }
    }
}
