using AgendaPersonal.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaPersonal.Context
{
    public class AgendaDatabaseContext : DbContext
    {

        public AgendaDatabaseContext(DbContextOptions<AgendaDatabaseContext> options)
        : base(options)
        {
        }
        public DbSet<Contacto> Contactos { get; set; }
    }



}

