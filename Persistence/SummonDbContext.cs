using SpellAndSummon.Models;
using Microsoft.EntityFrameworkCore;

namespace SpellAndSummon.Persistence
{
    public class SummonDbContext: DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<CardDeck> CardDecks { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<SpecialAbility> SpecialAbilities { get; set; }
        public DbSet<SpecialAbilityCard> SpecialAbilityCards { get; set; }
        public SummonDbContext(DbContextOptions<SummonDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardDeck>()
                .HasKey(cd => cd.Id);
                
            modelBuilder.Entity<SpecialAbilityCard>()
                .HasKey(sc => new{sc.CardId, sc.SpecialAbilityId});
        }
    }
}