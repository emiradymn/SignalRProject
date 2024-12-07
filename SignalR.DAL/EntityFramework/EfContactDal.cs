using System;
using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfContactDal : GenericRepository<Contact>, IContactDal
{
    public EfContactDal(SignalRContext context) : base(context)
    {
    }
}
