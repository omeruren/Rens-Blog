namespace RensBlog.Application.Contracts.Persistance;

public interface IUnitOfWork
{
    Task<bool> SaveChangesAsync();
}
