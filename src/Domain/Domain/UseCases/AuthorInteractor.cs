using AutoMapper;
using Domain.Entities;
using Domain.Models;
using Domain.Repositories;
using Domain.Services.Interface;

namespace Domain.Services;

public class AuthorInteractor : IAuthorInteractor
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public AuthorInteractor(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<int> CreateAsync(AuthorPostRequest request)
    {
        var author = _mapper.Map<Author>(request);
        Author a = new Author()
        {
            Gender = request.Gender,
            Name = request.Name
        };
        await _unitOfWork.GetRepository<Author>().CreateAsync(author);
        await _unitOfWork.CompleteAsync();
        return author.Id;
    }

    public async Task<List<AuthorGetResponse>> GetAsync()
    {
        var result = _unitOfWork.GetRepository<Author>().FindAllAsync().ToList();
        var bora = _mapper.Map<List<AuthorGetResponse>>(result);
        return bora;
    }
}