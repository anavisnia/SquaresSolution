using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace SquaresSolution.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextFileController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostFormdata([FromForm] IFormFile file)
        {
            using (var sr = new StreamReader(file.OpenReadStream()))
            {
                var content = await sr.ReadToEndAsync();
                return Ok(content);
            }
        }
    }
}
