using System;
using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfAboutDal : GenericRepository<About>, IAboutDal
{
    public EfAboutDal(SignalRContext context) : base(context)
    {
    }
}
