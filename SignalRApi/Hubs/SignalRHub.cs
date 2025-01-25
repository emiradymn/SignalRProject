using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.Business.Abstract;
using SignalR.DAL.Concrete;

namespace SignalRApi.Hubs;

public class SignalRHub : Hub
{
    private readonly ICategoryService _categoryService;  // hepsini tek tek yazmak yerine mediatr kullanılabilir buraya bak sonra !!
    private readonly IProductService _productService;
    private readonly IMenuTableService _menuTableService;
    private readonly IOrderService _orderService;
    private readonly IMoneyCaseService _moneyCaseService;

    public SignalRHub(ICategoryService categoryService, IProductService productService, IMenuTableService menuTableService, IOrderService orderService, IMoneyCaseService moneyCaseService)
    {
        _categoryService = categoryService;
        _productService = productService;
        _menuTableService = menuTableService;
        _orderService = orderService;
        _moneyCaseService = moneyCaseService;

    }

    public async Task SendStatistic()
    {
        var value = _categoryService.TCategoryCount();
        await Clients.All.SendAsync("ReceiveCategoryCount", value);

        var value2 = _productService.TProductCount();
        await Clients.All.SendAsync("ReceiveProductCount", value2);

        var value3 = _categoryService.TActiveCategoryCount();
        await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

        var value4 = _categoryService.TPassiveCategoryCount();
        await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

        var value5 = _menuTableService.TMenuTableCount();
        await Clients.All.SendAsync("ReceiveMenuTableCount", value5);

        var value6 = _orderService.TTotalOrderCount();
        await Clients.All.SendAsync("ReceiveTotalOrderCount", value6);

        var value7 = _orderService.TActiveOrderCount();
        await Clients.All.SendAsync("ReceiveActiveOrderCount", value7);

        var value9 = _moneyCaseService.TTotalMoneyCaseAmount();
        await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value9);

        var value10 = _productService.TProductNameByMaxPrice();
        await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value10);

        var value11 = _productService.TProductNameByMinPrice();
        await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value11);

        var value12 = _menuTableService.TMenuTableCount();
        await Clients.All.SendAsync("ReceiveMenuTableCount", value12);

        var value13 = _orderService.TLastOrderPrice();
        await Clients.All.SendAsync("ReceiveLastOrderPrice", value13);
    }

}
