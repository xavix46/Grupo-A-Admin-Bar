using BarAPI.Models;

namespace BarAPI.Services;

public interface ITokenService
{
    (string Token, DateTime Expira) CrearToken(ApplicationUser user, IList<string> roles);
}