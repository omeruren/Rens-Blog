using RensBlog.Domain.Entities.Common;
using System.Linq.Expressions;

namespace RensBlog.Application.Contracts.Persistance;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<List<TEntity>> GetAllAsync();
    Task<IQueryable> GetQueryAsync();
    Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter);
    Task<TEntity> GetByIdAsync(Guid id);
    Task CrateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);

}
