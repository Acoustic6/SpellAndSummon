using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpellAndSummon.Core;

namespace SpellAndSummon.Persistence {
    public class UnitOfWork: IUnitOfWork 
    {
        public ICardsRepository Cards { get; private set; }
        public ISpecialAbilitiesRepository SpecialAbilities { get; private set; }
        private readonly SummonDbContext Context;
        public UnitOfWork (SummonDbContext context) 
        {
            this.Context = context;
            this.Cards = new CardsRepository(Context);
        }
        public void Complete()
        {
            Context.SaveChanges();
        }
        public async Task CompleteAsync()
        {
            await Context.SaveChangesAsync();
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}