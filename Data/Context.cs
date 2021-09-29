using Microsoft.EntityFrameworkCore;
using prova.Model;

namespace prova.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Filme> Filmes { get; set; }

    }
}