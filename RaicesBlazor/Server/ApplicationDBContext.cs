using Microsoft.EntityFrameworkCore;
using RaicesBlazor.Shared.Modelos;

namespace RaicesBlazor.Server
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Clasificacion> Clasificacion { get; set; }
        public DbSet<Mercancia> Mercancia { get; set; }
        public DbSet<AlmacenItems> AlmacenItems { get; set; }
        public DbSet<Recepcion> Recepcion { get; set; }
        public DbSet<RecepcionItem> RecepcionItem { get; set; }
        public DbSet<TipoTProducto> TipoTProducto { get; set; }
        public DbSet<TProducto> TProducto { get; set; }
        public DbSet<Vale> Vale { get; set; }
        public DbSet<ValeItem> ValeItem { get; set; }
        public DbSet<ZEstudiantes> Estudiante { get; set; }

        public DbSet<ZDirecciones> Direccion { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {

        }
    }
}
