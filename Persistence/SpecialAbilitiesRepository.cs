using SpellAndSummon.Core;
using SpellAndSummon.Models;

namespace SpellAndSummon.Persistence
{
    public class SpecialAbilitiesRepository: Repository<SpecialAbility, int>, ISpecialAbilitiesRepository
    {
        private SummonDbContext _context 
        { 
            get
            {
                return Context as SummonDbContext;
            }
        }    
        public SpecialAbilitiesRepository(SummonDbContext context)
            : base(context)
        {
        }
    }
}