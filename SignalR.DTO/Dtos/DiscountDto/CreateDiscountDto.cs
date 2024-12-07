using System;

namespace SignalR.DTO.Dtos.DiscountDto;

public class CreateDiscountDto
{
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
