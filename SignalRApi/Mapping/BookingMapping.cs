using System;
using AutoMapper;
using SignalR.DTO.Dtos.BookingDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Mapping;

public class BookingMapping : Profile
{
    public BookingMapping()
    {
        CreateMap<Booking, ResultBookingDto>().ReverseMap();
        CreateMap<Booking, CreateBookingDto>().ReverseMap();
        CreateMap<Booking, GetBookingDto>().ReverseMap();
        CreateMap<Booking, UpdateBookingDto>().ReverseMap();
    }
}
