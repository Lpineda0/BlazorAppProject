using Microsoft.EntityFrameworkCore;

namespace BlazorAppProject.Modelo
{
    public class CatalogoDBContext : DbContext 
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options) 
        { 
        }
        public DbSet<Persona> Personas { get; set; }
		public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Renta> Rentas { get; set; }
    }
}
