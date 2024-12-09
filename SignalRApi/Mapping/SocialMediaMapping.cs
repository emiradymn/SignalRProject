using System;
using AutoMapper;
using SignalR.DTO.Dtos.SocialMediaDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Mapping;

public class SocialMediaMapping : Profile
{
    public SocialMediaMapping()
    {
        CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
    }
}
