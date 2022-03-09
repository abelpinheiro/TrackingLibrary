using TL.Catalog.Domain.Interfaces;
using TL.Catalog.Domain.Models;

namespace TL.Catalog.Infrastructure.Repositories;

public class AuthorRepository : IAuthorRepository
{
    public Task<Author> CreateAsync(Author author)
    {
        throw new NotImplementedException();
    }

    public Task<Author> UpdateAsync(Author author)
    {
        throw new NotImplementedException();
    }

    public Task<Author> DeleteAsync(Author author)
    {
        throw new NotImplementedException();
    }

    public Task<Author> GetByIdAsync(Author author)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Author>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}