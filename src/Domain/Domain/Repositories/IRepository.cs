using System.Linq.Expressions;

namespace Domain.Repositories;

public interface IRepository<T> where T : IEntity
{
    Task CreateAsync(T entity);
    IQueryable<T> FindAllAsync();
    T FindByIdAsync(Expression<Func<T, bool>> predicate);
    void UpdateAsync(T entity);
    void DeleteAsync(T entity);
}