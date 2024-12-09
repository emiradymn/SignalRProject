using System;
using AutoMapper;
using SignalR.DTO.Dtos.DiscountDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Mapping;

public class DiscountMapping : Profile
{
    public DiscountMapping()
    {
        CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        CreateMap<Discount, GetDiscountDto>().ReverseMap();
        CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
    }
}
