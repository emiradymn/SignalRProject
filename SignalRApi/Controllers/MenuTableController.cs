using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;

namespace SignalRApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MenuTableController : ControllerBase
{
    private readonly IMenuTableService _menuTableService;

    public MenuTableController(IMenuTableService menuTableService)
    {
        _menuTableService = menuTableService;
    }

    [HttpGet("MenuTableCount")]
    public IActionResult MenuTableCount()
    {
        return Ok(_menuTableService.TMenuTableCount());
    }

}
