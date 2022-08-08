using Domain.Entities;
using Domain.Repositories;
//using Domain.Services.Interface;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public IRepository<Author> Authors { get; }
    private readonly TrackingLibraryDbContext _context;

    public UnitOfWork(TrackingLibraryDbContext context/*,
        IRepository<Author> authors*/)
    {
        _context = context;
        //Authors = authors;
    }
    
    public async ValueTask DisposeAsync()
    {
        await Task.Yield();
        Console.WriteLine("Cleaned up!");
    }

    public Task<int> CompleteAsync()
    {
        return _context.SaveChangesAsync();
    }
}