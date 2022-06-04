using TL.Catalog.Application.DTOs;
using TL.Catalog.Application.Interfaces;
using TL.Catalog.Domain.Interfaces;
using TL.Catalog.Domain.Models;

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

    public async Task<AuthorDTO> GetByIdAsync(int id)
    {
        var author = await _authorRepository.GetByIdAsync(id);
        return new AuthorDTO()
        {
            Id = author.Id,
            Name = author.Name,
            Gender = author.Gender
        };
    }

    public async Task<int> CreateAsync(AuthorDTO authorDTO)
    {
        Author author = new Author()
        {
            Name = authorDTO.Name,
            Gender = authorDTO.Gender
        };

        return await _authorRepository.CreateAsync(author);
    }

    public async Task EditAsync(AuthorDTO authorDTO)
    {
        await _authorRepository.UpdateAsync(new Author()
        {
            Id = authorDTO.Id,
            Name = authorDTO.Name,
            Gender = authorDTO.Gender
        });
    }

    public async Task DeleteByIdAsync(int id)
    {
        var author = await _authorRepository.GetByIdAsync(id);
        await _authorRepository.DeleteByIdAsync(author);
    }
}