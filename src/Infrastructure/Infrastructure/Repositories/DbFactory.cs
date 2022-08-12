using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DbFactory : IAsyncDisposable
{
    private bool _disposed;
    private Func<DbContext> _instanceFunc;
    private DbContext _dbContext;
    public DbContext DbContext => _dbContext ??= _instanceFunc.Invoke();

    public DbFactory(Func<DbContext> dbContextFactory)
    {
        _instanceFunc = dbContextFactory;
    }
    
    public async ValueTask DisposeAsync()
    {
        await _dbContext.DisposeAsync();
        _disposed = true;
    }
}