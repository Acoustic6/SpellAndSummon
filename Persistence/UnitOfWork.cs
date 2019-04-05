using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpellAndSummon.Core;

namespace SpellAndSummon.Persistence {
    public class UnitOfWork {
        public ICardsRepository Cards { get; private set; }
        private readonly SummonDbContext _context;
        public UnitOfWork (SummonDbContext context) 
        {
            this._context = context;
            this.Cards = new CardsRepository(_context);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}