using System;

namespace SignalR.DTO.Dtos.SocialMediaDto;

public class GetSocialMediaDto
{
    public int SocialMediaID { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string ImageUrl { get; set; }
}
