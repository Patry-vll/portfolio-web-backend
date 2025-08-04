using Ejercicio1Api.Models;
using Microsoft.EntityFrameworkCore;
//using Ejercicio1Api.Models;



namespace Ejercicio1Api.Context
{
    public class AppDbContext : DbContext

    { // creción del constructor 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Persona> Personas { get; set; }

    }
}
