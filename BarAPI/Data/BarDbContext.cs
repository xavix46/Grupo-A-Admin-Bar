using BarAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BarAPI.Data;

public class BarDbContext : IdentityDbContext<ApplicationUser>
{
    public BarDbContext(DbContextOptions<BarDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // siempre primero
        // Aquí irán las entidades del bar (Producto, Pedido, etc.) en próximas prácticas
    }
}