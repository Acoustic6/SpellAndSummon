using SpellAndSummon.Models;
using Microsoft.EntityFrameworkCore;

namespace SpellAndSummon.Persistence
{
    public class SummonDbContext: DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<DeckSlot> DeckSlots { get; set; }
        public DbSet<Card> Cards { get; set; }
        public SummonDbContext(DbContextOptions<SummonDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}