using Microsoft.AspNetCore.Identity;

namespace BarAPI.Models;

public class ApplicationUser : IdentityUser
{
    public string NombreCompleto { get; set; } = string.Empty;
}