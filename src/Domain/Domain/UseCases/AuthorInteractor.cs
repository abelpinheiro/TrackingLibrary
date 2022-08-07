using Domain.Entities;
using Domain.Repositories;
using Domain.Services.Interface;

namespace Domain.Services;

public class AuthorInteractor: IAuthorInteractor
{
    //private readonly IUnitOfWork _unitOfWork;

    public AuthorInteractor(/*IUnitOfWork unitOfWork*/)
    {
        //_unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(string request)
    {
        var author = new Author();
        int[] nums = new[] { 1 };
        var x = nums.ToList();
        x.Sort();
        for (int i = 0; i < x.Count; i++)
        {
            
        }
        //_unitOfWork.Authors.Create(author);
        //await _unitOfWork.CompleteAsync();
    }
}