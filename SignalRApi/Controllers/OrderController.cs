using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;

namespace SignalRApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    [HttpGet("TotalOrderCount")]
    public IActionResult TotalOrderCount()
    {
        return Ok(_orderService.TTotalOrderCount());
    }

    [HttpGet("ActiveOrderCount")]
    public IActionResult ActiveOrderCount()
    {
        return Ok(_orderService.TActiveOrderCount());
    }

    [HttpGet("LastOrderPrice")]
    public IActionResult LastOrderPrice()
    {
        return Ok(_orderService.TLastOrderPrice());
    }

    [HttpGet("TodayTotalPrice")]
    public IActionResult TodayTotalPrice()
    {
        return Ok(_orderService.TTodayTotalPrice());
    }
}
