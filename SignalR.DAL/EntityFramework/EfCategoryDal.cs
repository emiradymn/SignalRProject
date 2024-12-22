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

    public int ActiveCategoryCount()
    {
        using var context = new SignalRContext();
        return context.Categories.Where(x => x.Status == true).Count();
    }

    public int CategoryCount()
    {
        using var context = new SignalRContext();
        return context.Categories.Count();
    }

    public int PassiveCategoryCount()
    {
        using var context = new SignalRContext();
        return context.Categories.Where(x => x.Status == false).Count();
    }
}
