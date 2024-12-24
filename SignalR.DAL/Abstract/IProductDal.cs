using System;
using SignalR.Entity.Entities;

namespace SignalR.DAL.Abstract;

public interface IProductDal : IGenericDal<Product>
{
    List<Product> GetProductsWithCategories();
    int ProductCount();
    int ProductCountByCategoryName(string categoryName);
    decimal ProductPriceAvg(string productName);
    string ProductNameByMaxPrice();
    string ProductNameByMinPrice();

}
