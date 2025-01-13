using SignalR.Entity.Entities;

namespace SignalR.DAL.Abstract;

public interface IOrderDal : IGenericDal<Order>
{
    int TotalOrderCount();
    int ActiveOrderCount();
    decimal LastOrderPrice();
    decimal TodayTotalPrice();
}
