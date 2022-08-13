using Squirrel.Domain.Entities.Base;
using System.Linq.Expressions;

namespace Squirrel.Domain.Interfaces
{
    public interface IRepository<TEntity> :IDisposable where TEntity : EntityBase
    {
        Task Insert(TEntity entity);
        Task<TEntity> GetId(Guid id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Delete(Guid id);


        /*Esse método usa uma expressão lambida para fazer buscas específicas
         * 
            Exemplo: Get(x => x.Name);         
         */
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> expression);
    }
}
