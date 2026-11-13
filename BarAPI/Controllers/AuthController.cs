using BarAPI.DTOs;
using BarAPI.Models;
using BarAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BarAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var respuesta = await _authService.LoginAsync(request);
        if (respuesta == null)
            return Unauthorized(new { mensaje = "Usuario o contraseña incorrectos, o cuenta bloqueada" });

        return Ok(respuesta);
    }

    [Authorize(Roles = Roles.Administrador)]
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var (ok, errores) = await _authService.RegisterAsync(request);
        if (!ok) return BadRequest(new { errores });

        return Ok(new { mensaje = "Usuario registrado correctamente", usuario = request.Usuario });
    }
}