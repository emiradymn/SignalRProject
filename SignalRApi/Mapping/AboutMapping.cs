using System;
using AutoMapper;
using SignalR.DTO.Dtos.AboutDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Mapping;

public class AboutMapping : Profile
{
    public AboutMapping()
    {
        CreateMap<About, ResultAboutDto>().ReverseMap();
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, GetAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
    }

}
