using TL.Catalog.Application.DTOs;

namespace TL.Catalog.Application.Interfaces;

public interface IAuthorService
{
    List<AuthorDTO> GetAllAsync();
}