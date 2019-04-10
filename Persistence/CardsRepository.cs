using SpellAndSummon.Models;
using SpellAndSummon.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SpellAndSummon.Persistence
{
    public class CardsRepository : Repository<Card, int>, ICardsRepository
    {
        private SummonDbContext _context 
        { 
            get
            {
                return Context as SummonDbContext;
            }
        }    
        public CardsRepository(SummonDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Card>> GetAllAsync(bool includeAbilities = false)
        {
            if (!includeAbilities)
                return await base.GetAllAsync();

            return await _context.Cards
                .Include(c => c.SpecialAbilityCards)
                    .ThenInclude(sc => sc.SpecialAbility)
                .ToListAsync();
        }
    }
}