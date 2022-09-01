using Microsoft.EntityFrameworkCore;
using RaicesBlazor.Shared.Modelos;

namespace RaicesBlazor.Server
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Almacen> Almacenes { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {

        }
    }
}
