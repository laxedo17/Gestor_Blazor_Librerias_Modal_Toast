using DatosAccceso.Modelos;
using Microsoft.EntityFrameworkCore;

namespace DatosAccceso.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Aqui pluralizamos Recetas, porque DbSet e como unha especie de coleccion
        //dado que teremos mais de unha receta
        public DbSet<Receta> Recetas { get; set; }
    }
}