using APIJuego.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace APIJuego.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 
        }

        public DbSet<Juego> Juegos { get; set; } // DbSet para el modelo Juego

       

    }
}
