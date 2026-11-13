namespace BarAPI.DTOs;

public record LoginRequest(string Usuario, string Password);

public record RegisterRequest(string Usuario, string Email, string Password,
                              string NombreCompleto, string Rol);

public record AuthResponse(string Token, DateTime Expira, string Usuario, IList<string> Roles);