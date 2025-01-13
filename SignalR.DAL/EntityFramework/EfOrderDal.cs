using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfOrderDal : GenericRepository<Order>, IOrderDal
{
    public EfOrderDal(SignalRContext context) : base(context)
    {
    }

    public int ActiveOrderCount()
    {
        using var context = new SignalRContext();
        return context.Orders.Where(x => x.Description == "müşteri masada").Count();
    }

    public decimal LastOrderPrice()
    {
        using var context = new SignalRContext();
        return context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
    }

    public decimal TodayTotalPrice()
    {
        using var context = new SignalRContext();
        return context.Orders.Where(x => x.Date == DateTime.Parse(DateTime.Now.ToShortDateString())).Sum(y => y.TotalPrice);
    }


    public int TotalOrderCount()
    {
        using var context = new SignalRContext();
        return context.Orders.Count();
    }
}
