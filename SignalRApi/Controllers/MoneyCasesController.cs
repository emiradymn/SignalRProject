using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;

namespace SignalRApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoneyCasesController : ControllerBase
{
    private readonly IMoneyCaseService _moneyCasesService;

    public MoneyCasesController(IMoneyCaseService moneyCasesService)
    {
        _moneyCasesService = moneyCasesService;
    }

    [HttpGet]
    public IActionResult TotalMoneyCaseAmount()
    {
        return Ok(_moneyCasesService.TTotalMoneyCaseAmount());
    }
}
