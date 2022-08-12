using Domain.Models;
using Domain.Repositories;

namespace Domain.Services.Interface;

public interface IAuthorInteractor
{
    public Task<int> CreateAsync(AuthorPostRequest request);
    public Task<List<AuthorGetResponse>> GetAsync();

}