using Domain.Entities;
using Domain.Services.Interface;

namespace Domain.Repositories;

public interface IUnitOfWork : IAsyncDisposable
{
    //TODO IMPLEMENTAÇÃO INICIAL DO UOW. MUDAR REPOSITORY PRA SER GENERICO DEPOIS
    //IRepository<Author> Authors { get; }
    //IAuthorInteractor Authors { get; }
    IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity;
    Task<int> CompleteAsync();
}