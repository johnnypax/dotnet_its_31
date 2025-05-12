using its31_lez05_api_sqlite.Models;
using Microsoft.EntityFrameworkCore;

namespace its31_lez05_api_sqlite.Context
{
    public class NegozioContext : DbContext
    {
        public NegozioContext(DbContextOptions<NegozioContext> options) : base(options) { } 

        public DbSet<Prodotto> Prodotti { get; set; }
    }
}
