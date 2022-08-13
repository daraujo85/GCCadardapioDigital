using Microsoft.EntityFrameworkCore;
using Squirrel.Domain.Entities.Base;
using Squirrel.Domain.Interfaces;
using Squirrel.Infra.Data.Context;
using System.Linq.Expressions;


namespace Squirrel.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase, new()
    {
        protected readonly CardapioDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(CardapioDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> expression)
        {
            return await DbSet.AsNoTracking().Where(expression).ToListAsync();
        }

        public virtual async Task<TEntity> GetId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Insert(TEntity entity)
        {
            DbSet.Add(entity);
            await Db.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
            DbSet.Update(entity);
            await Db.SaveChangesAsync();
        }

        public virtual async Task Delete(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
