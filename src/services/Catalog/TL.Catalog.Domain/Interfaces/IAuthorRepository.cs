using TL.Catalog.Domain.Models;

namespace TL.Catalog.Domain.Interfaces;

public interface IAuthorRepository
{
    Task<int> CreateAsync(Author author);
    Task UpdateAsync(Author author);
    Task<Author> DeleteAsync();
    Task DeleteByIdAsync(Author author);
    Task<Author> GetByIdAsync(int id);
    List<Author> GetAllAsync();
}