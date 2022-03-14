using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using TL.Catalog.Domain.Interfaces;
using TL.Catalog.Domain.Models;
using TL.Catalog.Infrastructure.Context;

namespace TL.Catalog.Infrastructure.Repositories;

public class AuthorRepository : IAuthorRepository
{
    public CatalogContext _context;

    public AuthorRepository(CatalogContext context)
    {
        _context = context;
    }

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

    public List<Author> GetAllAsync()
    {
        return 
            _context.Authors.ToList();
    }

}