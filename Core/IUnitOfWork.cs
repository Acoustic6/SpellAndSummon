using System;
using System.Threading.Tasks;

namespace SpellAndSummon.Core
{
    public interface IUnitOfWork: IDisposable
    {
        ICardsRepository Cards { get; }
        void Complete();
        Task CompleteAsync();
    }
}