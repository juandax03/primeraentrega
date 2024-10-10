using Microsoft.EntityFrameworkCore;
using MiBackendAPI.Models;

namespace MiBackendAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TipoProducto> TipoProductos { get; set; }
    }
}
