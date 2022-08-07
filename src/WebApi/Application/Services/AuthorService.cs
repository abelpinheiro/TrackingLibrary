using Application.DataTransferObjects;
using Application.Services.Interface;
using Domain.Services.Interface;

namespace Application.Services;

public class AuthorService : IAuthorService
{
    private IAuthorInteractor _authorInteractor;

    public AuthorService(IAuthorInteractor authorInteractor)
    {
        _authorInteractor = authorInteractor;
    }
    
    public async Task CreateAsync(AuthorPostRequest request)
    {
        string h = "";
        await _authorInteractor.CreateAsync(h);
    }
}