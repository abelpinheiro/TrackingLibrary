using System.Linq.Expressions;

namespace Domain.Repositories;

public interface IRepository<T> where T : IEntity
{
    void Create(T entity);
    IQueryable<T> FindAll();
    T FindById(Expression<Func<T, bool>> predicate);
    void Update(T entity);
    void Delete(T entity);
}