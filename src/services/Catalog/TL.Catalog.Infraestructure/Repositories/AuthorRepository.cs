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

    public async Task<int> CreateAsync(Author author)
    {
        await _context.Authors.AddAsync(author);
        await _context.SaveChangesAsync();

        return author.Id;
    }

    public async Task UpdateAsync(Author newAuthor)
    {
        var author = await GetByIdAsync(newAuthor.Id);
        author.Name = newAuthor.Name;
        author.Gender = newAuthor.Gender;
        await _context.SaveChangesAsync();
    }

    public Task<Author> DeleteAsync()
    {
        throw new NotImplementedException();
    }

    public async Task DeleteByIdAsync(Author author)
    {
        _context.Authors.Remove(author);
        await _context.SaveChangesAsync();
    }

    public async Task<Author> GetByIdAsync(int id)
    {
        return await _context.Authors.FindAsync(id);
    }

    public List<Author> GetAllAsync()
    {
        return _context.Authors.ToList();
    }

}