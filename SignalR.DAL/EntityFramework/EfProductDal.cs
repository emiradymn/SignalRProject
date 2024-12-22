using System;
using Microsoft.EntityFrameworkCore;
using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(SignalRContext context) : base(context)
    {
    }
    public List<Product> GetProductsWithCategories()
    {
        var context = new SignalRContext();
        var values = context.Products.Include(x => x.Category).ToList();
        return values;
    }

    public int ProductCount()
    {
        var context = new SignalRContext();
        return context.Products.Count();
    }

    public int ProductCountByCategoryName()
    {
        var context = new SignalRContext();
        return context.Products.Count(x => x.Category.CategoryName == "Hamburger");
    }

    public int ProductCountByCategoryName(string categoryName)
    {
        var context = new SignalRContext();
        return context.Products.Count(x => x.Category.CategoryName.ToLower() == categoryName.ToLower());
    }
}
