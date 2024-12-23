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

}
