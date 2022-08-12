using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace Domain.Mappers;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        SetupInbound();
        SetupOutbond();
    }

    private void SetupInbound()
    {
        CreateMap<AuthorPostRequest, Author>();
    }

    private void SetupOutbond()
    {
        CreateMap<Author, AuthorGetResponse>();
    }
}