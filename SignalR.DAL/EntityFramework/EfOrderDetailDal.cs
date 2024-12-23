using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfOrderDetailDal : GenericRepository<OrderDetail>, IOrderDetailDal
{
    public EfOrderDetailDal(SignalRContext context) : base(context)
    {
    }

}
