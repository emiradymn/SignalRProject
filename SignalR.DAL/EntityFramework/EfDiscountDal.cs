using System;
using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
{
    public EfDiscountDal(SignalRContext context) : base(context)
    {
    }
}
