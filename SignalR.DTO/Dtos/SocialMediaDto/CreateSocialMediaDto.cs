using System;

namespace SignalR.DTO.Dtos.SocialMediaDto;

public class CreateSocialMediaDto
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string ImageUrl { get; set; }
}