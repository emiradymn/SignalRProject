using System;
using SignalR.Entity.Entities;

namespace SignalR.Business.Abstract;

public interface IProductService : IGenericService<Product>
{
    List<Product> TGetProductsWithCategories();
    int TProductCount();
    int TProductCountByCategoryName(string categoryName);
    decimal TProductPriceAvg(string productName);
    string TProductNameByMaxPrice();
    string TProductNameByMinPrice();


}
