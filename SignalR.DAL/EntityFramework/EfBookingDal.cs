using System;
using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfBookingDal : GenericRepository<Booking>, IBookingDal
{
    public EfBookingDal(SignalRContext context) : base(context)
    {
    }
}
