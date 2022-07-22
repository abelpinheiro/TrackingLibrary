using System.Linq.Expressions;
using Domain.Repositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class, IEntity
{

    private readonly TrackingLibraryDbContext _context;
    private DbSet<T> _dataset;

    public Repository(TrackingLibraryDbContext context)
    {
        _context = context;
        _dataset = _context.Set<T>();
    }

    public void Create(T entity)
    {
        _dataset.Add(entity);
        _context.SaveChanges();
    }

    public IQueryable<T> FindAll()
    {
        return _dataset.AsNoTracking();
    }

    public T FindById(Expression<Func<T, bool>> predicate)
    {
        return _dataset.FirstOrDefault(predicate);
    }

    public void Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _dataset.Update(entity);
    }

    public void Delete(T entity)
    {
        _dataset.Remove(entity);
    }
}