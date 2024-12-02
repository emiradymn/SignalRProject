using System;

namespace SignalR.Entity.Entities;

public class Discount
{
    public int DiscountID { get; set; }
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
