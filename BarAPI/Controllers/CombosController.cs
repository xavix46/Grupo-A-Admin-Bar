using BarAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BarAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CombosController : ControllerBase
    {
        [HttpGet] // cualquier usuario con token
        public IActionResult GetCombos()
        {
            return Ok(new { mensaje = "API de combos funcionando correctamente" });
        }

        [HttpPost]
        [Authorize(Roles = Roles.Administrador)] // solo administrador
        public IActionResult CrearCombo()
        {
            return Ok(new { mensaje = "Combo creado (solo Administrador)" });
        }
    }
}