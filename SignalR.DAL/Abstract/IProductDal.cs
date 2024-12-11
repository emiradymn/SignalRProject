using System;
using SignalR.Entity.Entities;

namespace SignalR.DAL.Abstract;

public interface IProductDal : IGenericDal<Product>
{
    List<Product> GetProductsWithCategories();
}
