using Microsoft.EntityFrameworkCore;

namespace MVCTeste.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresa { get; set; }
    }
}
