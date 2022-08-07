namespace Domain.Services.Interface;

public interface IAuthorInteractor
{
    public Task CreateAsync(string request);
}