using Application.DataTransferObjects;
using AutoMapper;
using Domain.Entities;

namespace Application.mappers;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    { 
        SetupInbound();
        SetupOutbond();
    }

    private void SetupOutbond()
    {
        CreateMap<Domain.Models.AuthorGetResponse, AuthorGetResponse>();
    }

    private void SetupInbound()
    {
        CreateMap<AuthorPostRequest, Domain.Models.AuthorPostRequest>();
    }
}