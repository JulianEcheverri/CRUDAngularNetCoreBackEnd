using CRUDAngular.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDAngular
{
    public class AplicationDbContext: DbContext
    {
        // Realizamos inyeccion de dependencias del objeto de contexto de la base de datos
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
        
        public DbSet<TarjetaDeCredito> TarjetasDeCredito { get; set; }
    }
}
