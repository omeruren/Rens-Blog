using RensBlog.Application.Contracts.Persistance;
using RensBlog.Persistance.Context;

namespace RensBlog.Persistance.Concrete;

internal class UnitOfWork(AppDbContext _context) : IUnitOfWork
{
    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
