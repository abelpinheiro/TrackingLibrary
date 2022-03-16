using System.Runtime.CompilerServices;
using TL.Catalog.Application.DTOs;

namespace TL.Catalog.Application.Interfaces;

public interface IAuthorService
{
    List<AuthorDTO> GetAllAsync();
    Task<AuthorDTO> GetByIdAsync(int id);
    Task<int> CreateAsync(AuthorDTO authorDTO);
    Task EditAsync(AuthorDTO authorDTO);
    Task DeleteByIdAsync(int id);
}