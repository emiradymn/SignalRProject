using SignalR.Entity.Entities;

namespace SignalR.Business.Abstract;

public interface IOrderService : IGenericService<Order>
{
    int TTotalOrderCount();
    int TActiveOrderCount();
    decimal TLastOrderPrice();
    decimal TTodayTotalPrice();
}
