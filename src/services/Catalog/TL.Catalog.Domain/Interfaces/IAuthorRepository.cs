using TL.Catalog.Domain.Models;

namespace TL.Catalog.Domain.Interfaces;

public interface IAuthorRepository
{
    Task<Author> CreateAsync(Author author);
    Task<Author> UpdateAsync(Author author);
    Task<Author> DeleteAsync(Author author);
    Task<Author> GetByIdAsync(Author author);
    List<Author> GetAllAsync();
}