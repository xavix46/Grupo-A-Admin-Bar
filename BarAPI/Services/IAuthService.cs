using BarAPI.DTOs;

namespace BarAPI.Services;

public interface IAuthService
{
    Task<AuthResponse?> LoginAsync(LoginRequest request);
    Task<(bool Ok, IEnumerable<string> Errores)> RegisterAsync(RegisterRequest request);
}