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
        public CardsRepository(DbContext _context)
            : base(_context)
        {
        }
    }
}