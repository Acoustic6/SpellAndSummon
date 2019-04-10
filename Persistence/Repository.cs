using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpellAndSummon.Core;

namespace SpellAndSummon.Persistence
{
    public class Repository<TEntity, TId>: IRepository<TEntity, TId>
        where TEntity: class
    {
        protected readonly DbContext Context;
        private readonly DbSet<TEntity> Entities;
        public Repository(DbContext context)
        {
            this.Context = context;
            Entities = this.Context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            Context.Add(entity);
        }
        public async Task AddAsync(TEntity entity)
        {
            await Context.AddAsync(entity);
        }
        public void Remove(TEntity entity)
        {
            Context.Remove(entity);
        }
        public TEntity Get(TId id)
        {
            return Entities.Find(id);
        }
        public async Task<TEntity> GetAsync(System.Int32 id)
        {
            return await Entities.FindAsync(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return Entities.ToList();
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Entities.ToListAsync();
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.Where(predicate).ToList();
        }
    }
}