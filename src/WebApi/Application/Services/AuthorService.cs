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
    
    public void CreateAsync()
    {
        _authorInteractor.CreateAsync();
    }
}