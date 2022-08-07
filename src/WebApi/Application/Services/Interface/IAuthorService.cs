using Application.DataTransferObjects;

namespace Application.Services.Interface;

public interface IAuthorService
{
    public Task CreateAsync(AuthorPostRequest request);
}