using BarAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace BarAPI.Data;

public static class IdentitySeeder
{
    public static async Task SeedAsync(IServiceProvider services, IConfiguration config)
    {
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

        foreach (var rol in Roles.Todos)
        {
            if (!await roleManager.RoleExistsAsync(rol))
                await roleManager.CreateAsync(new IdentityRole(rol));
        }

        var email = config["SeedAdmin:Email"];
        var password = config["SeedAdmin:Password"];
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            return;

        var admin = await userManager.FindByEmailAsync(email);
        if (admin == null)
        {
            admin = new ApplicationUser
            {
                UserName = "admin",
                Email = email,
                NombreCompleto = "Administrador"
            };

            var resultado = await userManager.CreateAsync(admin, password);
            if (!resultado.Succeeded)
            {
                var errores = string.Join(", ", resultado.Errors.Select(e => e.Description));
                throw new InvalidOperationException("No se pudo crear el usuario Admin: " + errores);
            }
        }

        if (!await userManager.IsInRoleAsync(admin, Roles.Administrador))
            await userManager.AddToRoleAsync(admin, Roles.Administrador);
    }
}