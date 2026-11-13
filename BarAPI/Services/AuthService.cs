using BarAPI.DTOs;
using BarAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace BarAPI.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenService _tokenService;

    public AuthService(UserManager<ApplicationUser> userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    public async Task<AuthResponse?> LoginAsync(LoginRequest request)
    {
        var user = await _userManager.FindByNameAsync(request.Usuario)
                   ?? await _userManager.FindByEmailAsync(request.Usuario);
        if (user == null) return null;

        if (await _userManager.IsLockedOutAsync(user)) return null;

        if (!await _userManager.CheckPasswordAsync(user, request.Password))
        {
            await _userManager.AccessFailedAsync(user);
            return null;
        }

        await _userManager.ResetAccessFailedCountAsync(user);

        var roles = await _userManager.GetRolesAsync(user);
        var (token, expira) = _tokenService.CrearToken(user, roles);

        return new AuthResponse(token, expira, user.UserName ?? string.Empty, roles);
    }

    public async Task<(bool Ok, IEnumerable<string> Errores)> RegisterAsync(RegisterRequest request)
    {
        if (!Roles.Todos.Contains(request.Rol))
            return (false, new[] { $"Rol inválido. Roles permitidos: {string.Join(", ", Roles.Todos)}" });

        var user = new ApplicationUser
        {
            UserName = request.Usuario,
            Email = request.Email,
            NombreCompleto = request.NombreCompleto
        };

        var resultado = await _userManager.CreateAsync(user, request.Password);
        if (!resultado.Succeeded)
            return (false, resultado.Errors.Select(e => e.Description));

        await _userManager.AddToRoleAsync(user, request.Rol);
        return (true, Array.Empty<string>());
    }
}