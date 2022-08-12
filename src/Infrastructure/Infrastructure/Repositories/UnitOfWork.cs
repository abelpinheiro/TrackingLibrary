using Domain.Entities;
using Domain.Repositories;
using Domain.Services.Interface;
//using Domain.Services.Interface;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    //private DbFactory _dbFactory;
    //public IAuthorInteractor Authors { get; }
    //public IRepository<Author> AuthorsRepository;
    private readonly TrackingLibraryDbContext _context;
    private bool _disposed;

    public UnitOfWork(TrackingLibraryDbContext context)
        //DbFactory dbFactory,
        //IAuthorInteractor authors)
    {
        //_dbFactory = dbFactory;
        _context = context;
        //Authors = authors;
    }
    
    public async ValueTask DisposeAsync()
    {
        //await Task.Yield();
        //await _dbFactory.DbContext.DisposeAsync();]
        if (!_disposed)
        {
            await _context.DisposeAsync();
        }
        
        _disposed = true;
        GC.SuppressFinalize(this);
        Console.WriteLine("Cleaned up!");
    }

    public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity
    {
        return new Repository<TEntity>(_context, this);
    }

    public async Task<int> CompleteAsync()
    {
        //return _dbFactory.DbContext.SaveChangesAsync();
        return await _context.SaveChangesAsync();
    }
}