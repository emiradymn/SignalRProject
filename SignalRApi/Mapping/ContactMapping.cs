using System;
using AutoMapper;
using SignalR.DTO.Dtos.ContactDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Mapping;

public class ContactMapping : Profile
{
    public ContactMapping()
    {
        CreateMap<Contact, ResultContactDto>().ReverseMap();
        CreateMap<Contact, CreateContactDto>().ReverseMap();
        CreateMap<Contact, GetContactDto>().ReverseMap();
        CreateMap<Contact, UpdateContactDto>().ReverseMap();
    }
}
