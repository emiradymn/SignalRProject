using System;
using SignalR.Entity.Entities;

namespace SignalR.Business.Abstract;

public interface IProductService : IGenericService<Product>
{
    List<Product> TGetProductsWithCategories();

}
