using System.Linq.Expressions;
using Domain.Repositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class, IEntity
{
    //private readonly DbFactory _dbFactory;
    private readonly TrackingLibraryDbContext _context;
    private DbSet<T> _dataset;
    private readonly IUnitOfWork _unitOfWork;

    /*protected DbSet<T> DbSet
    {
        //get => _dataset ??= _dbFactory.DbContext.Set<T>();
    }*/

    public Repository(TrackingLibraryDbContext context/*, DbFactory dbFactory*/, IUnitOfWork unitOfWork)
    {
        //_dbFactory = dbFactory;
        _context = context;
        _dataset = _context.Set<T>();
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(T entity)
    {
        await _dataset.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public IQueryable<T> FindAllAsync()
    {
        return _dataset.AsNoTracking();
    }

    public T FindByIdAsync(Expression<Func<T, bool>> predicate)
    {
        return _dataset.FirstOrDefault(predicate);
    }

    public void UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _dataset.Update(entity);
    }

    public void DeleteAsync(T entity)
    {
        _dataset.Remove(entity);
    }
}