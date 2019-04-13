using System;
using System.Threading.Tasks;

namespace SpellAndSummon.Core
{
    public interface IUnitOfWork: IDisposable
    {
        ICardsRepository Cards { get; }
        ISpecialAbilitiesRepository SpecialAbilities { get; }
        void Complete();
        Task CompleteAsync();
    }
}