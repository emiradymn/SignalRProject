using System;
using SignalR.Business.Abstract;
using SignalR.DAL.Abstract;
using SignalR.Entity.Entities;

namespace SignalR.Business.Concrete;

public class DiscountManager : IDiscountService
{
    private readonly IDiscountDal _discountDal;

    public DiscountManager(IDiscountDal discountDal)
    {
        _discountDal = discountDal;
    }

    public void TAdd(Discount entity)
    {
        _discountDal.Add(entity);
    }

    public void TDelete(Discount entity)
    {
        _discountDal.Delete(entity);
    }

    public Discount TGetById(int id)
    {
        return _discountDal.GetById(id);
    }

    public List<Discount> TGetListAll()
    {
        return _discountDal.GetListAll();
    }

    public void TUpdate(Discount entity)
    {
        _discountDal.Update(entity);
    }
}
