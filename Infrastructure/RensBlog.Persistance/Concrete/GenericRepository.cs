using Microsoft.EntityFrameworkCore;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Domain.Entities.Common;
using RensBlog.Persistance.Context;
using System.Linq.Expressions;

namespace RensBlog.Persistance.Concrete;

public class GenericRepository<TEntity>(AppDbContext _context) : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly DbSet<TEntity> _table = _context.Set<TEntity>(); // Represent the table name in App DbContext 
    public async Task CrateAsync(TEntity entity)
    {
        _context.AddAsync(entity); // save changes calling at Unit Of Work
    }

    public void Delete(TEntity entity)
    {
        _table.Remove(entity);
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _table.AsNoTracking().ToListAsync(); // As no Tracking : Performance improvement . We are not doing any change on table
    }

    public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
    {
        return _table.AsNoTracking().Where(filter).ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        return await _table.FindAsync(id);
    }

    public IQueryable<TEntity> GetQuery()
    {
        return _table;
    }

    public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter)
    {
        return await _table.AsNoTracking().FirstOrDefaultAsync(filter);
    }

    public void Update(TEntity entity)
    {
        _context.Update(entity);
    }
}
