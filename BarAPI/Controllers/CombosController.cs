using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CombosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCombos()
        {
            return Ok(new
            {
                mensaje = "API de combos funcionando correctamente"
            });
        }
    }
}
