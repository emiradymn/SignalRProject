using System;
using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
{
    public EfCategoryDal(SignalRContext context) : base(context)
    {
    }
}
