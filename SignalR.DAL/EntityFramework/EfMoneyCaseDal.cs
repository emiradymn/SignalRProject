using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
{
    public EfMoneyCaseDal(SignalRContext context) : base(context)
    {
    }

    public decimal TotalMoneyCaseAmount()
    {
        using var context = new SignalRContext();
        return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
    }

}
