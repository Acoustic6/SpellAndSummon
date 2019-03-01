using Microsoft.EntityFrameworkCore;

namespace SpellAndSummon.Persistence
{
    public class SummonDbContext: DbContext
    {
        public SummonDbContext(DbContextOptions<SummonDbContext> options)
            :base(options)
        {
            
        }
    }
}