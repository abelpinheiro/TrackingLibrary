using Application.DataTransferObjects;

namespace Application.Services.Interface;

public interface IAuthorService
{
    public Task<int> CreateAsync(AuthorPostRequest request);
    public Task<List<AuthorGetResponse>> GetAsync();
}