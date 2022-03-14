using TL.Catalog.Application.DTOs;
using TL.Catalog.Application.Interfaces;
using TL.Catalog.Domain.Interfaces;

namespace TL.Catalog.Application.Services;

public class AuthorService : IAuthorService
{
    public IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public List<AuthorDTO> GetAllAsync()
    {
        var authors = _authorRepository.GetAllAsync();

        List<AuthorDTO> result = new List<AuthorDTO>();
        foreach (var author in authors)
        {
            AuthorDTO item = new AuthorDTO()
            {
                Id = author.Id,
                Name = author.Name,
                Gender = author.Gender
            };

            result.Add(item);
        }

        return result;
    }
}