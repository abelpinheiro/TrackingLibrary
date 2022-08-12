using Application.DataTransferObjects;
using Application.Services.Interface;
using AutoMapper;
using Domain.Entities;
using Domain.Services.Interface;

namespace Application.Services;

public class AuthorService : IAuthorService
{
    private readonly IAuthorInteractor _authorInteractor;
    private readonly IMapper _mapper;

    public AuthorService(IAuthorInteractor authorInteractor, IMapper mapper)
    {
        _authorInteractor = authorInteractor;
        _mapper = mapper;
    }
    
    //TODO FIX AUTOMAPPER
    public async Task<int> CreateAsync(AuthorPostRequest request)
    {
        var author = _mapper.Map<Domain.Models.AuthorPostRequest>(request);
        Domain.Models.AuthorPostRequest a = new Domain.Models.AuthorPostRequest()
        {
            Gender = request.Gender,
            Name = request.Name
        };
        
        return await _authorInteractor.CreateAsync(author);
    }

    public async Task<List<AuthorGetResponse>> GetAsync()
    {
        var result = await _authorInteractor.GetAsync();
        return _mapper.Map<List<AuthorGetResponse>>(result);
    }
}