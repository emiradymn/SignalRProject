using System;
using AutoMapper;
using SignalR.DTO.Dtos.TestimonialDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Mapping;

public class TestimonialMapping : Profile
{
    public TestimonialMapping()
    {
        CreateMap<Testimonial, ResultTestimonalDto>().ReverseMap();
        CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
    }
}
