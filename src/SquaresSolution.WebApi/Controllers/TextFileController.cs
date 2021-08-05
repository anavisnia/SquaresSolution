using Microsoft.AspNetCore.Mvc;
using SquaresSolution.Domain.Entities;
using SquaresSolution.Domain.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresSolution.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextFileController : ControllerBase
    {
        private readonly PointsService _service;

        public TextFileController(PointsService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpPost]
        public async Task<IActionResult> PostFormdata()
        {
            var files = Request.Form.Files;
            List<PointEntity> recievedPoints = new List<PointEntity>();

            var result = new StringBuilder();
            foreach (var file in files)
            {
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    while (reader.Peek() >= 0)
                    {
                        var pointText = await reader.ReadLineAsync();
                        var pointAsString = pointText.Split(" ").ToList();
                        if (pointAsString.Count() == 2)
                        {
                            var newPoint = new PointEntity();

                            newPoint.X = Int32.Parse(pointAsString[0]);
                            newPoint.Y = Int32.Parse(pointAsString[1]);

                            recievedPoints.Add(newPoint);
                        }
                    }
                }
            }

            foreach (var recievedPoint in recievedPoints)
            {
                await _service.AddPointAsync(recievedPoint);
            }

            return Ok();
        }
    }
}
