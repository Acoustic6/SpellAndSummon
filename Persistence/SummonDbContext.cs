using SpellAndSummon.Models;
using Microsoft.EntityFrameworkCore;

namespace SpellAndSummon.Persistence
{
    public class SummonDbContext: DbContext
    {
        public DbSet<Deck> Decks { get; set; }
        public SummonDbContext(DbContextOptions<SummonDbContext> options)
            :base(options)
        {
        }
    }
}