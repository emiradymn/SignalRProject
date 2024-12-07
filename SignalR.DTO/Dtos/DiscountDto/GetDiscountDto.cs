using System;

namespace SignalR.DTO.Dtos.DiscountDto;

public class GetDiscountDto
{
    public int DiscountID { get; set; }
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
