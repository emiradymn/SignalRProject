using SignalR.Business.Abstract;
using SignalR.DAL.Abstract;
using SignalR.Entity.Entities;

namespace SignalR.Business.Concrete;

public class OrderDetailManager : IOrderDetailService
{
    private readonly IOrderDetailDal _orderDetailDal;

    public OrderDetailManager(IOrderDetailDal orderDetailDal)
    {
        _orderDetailDal = orderDetailDal;
    }

    public void TAdd(OrderDetail entity)
    {
        _orderDetailDal.Add(entity);
    }

    public void TDelete(OrderDetail entity)
    {
        _orderDetailDal.Delete(entity);
    }

    public OrderDetail TGetById(int id)
    {
        return _orderDetailDal.GetById(id);
    }

    public List<OrderDetail> TGetListAll()
    {
        return _orderDetailDal.GetListAll();
    }

    public void TUpdate(OrderDetail entity)
    {
        _orderDetailDal.Update(entity);
    }
}
