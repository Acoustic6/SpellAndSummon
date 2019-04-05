using System.Threading.Tasks;

namespace SpellAndSummon.Core
{
    public interface IUnitOfWork
    {
        ICardsRepository cardsRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}