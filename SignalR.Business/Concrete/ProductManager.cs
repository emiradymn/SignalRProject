using System;
using SignalR.Business.Abstract;
using SignalR.DAL.Abstract;
using SignalR.Entity.Entities;

namespace SignalR.Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    // public List<Product> GetProductsWithCategories()
    // {
    //     return _productDal.TGetProductsWithCategories();
    // }

    public void TAdd(Product entity)
    {
        _productDal.Add(entity);
    }

    public void TDelete(Product entity)
    {
        _productDal.Delete(entity);
    }

    public Product TGetById(int id)
    {
        return _productDal.GetById(id);
    }

    public List<Product> TGetListAll()
    {
        return _productDal.GetListAll();
    }

    public List<Product> TGetProductsWithCategories()
    {
        return _productDal.GetProductsWithCategories();
    }

    public int TProductCount()
    {
        return _productDal.ProductCount();
    }

    public int TProductCountByCategoryName(string categoryName)
    {
        if (string.IsNullOrWhiteSpace(categoryName))
            throw new ArgumentException("Doğru Kategori değil");

        return _productDal.ProductCountByCategoryName(categoryName);
    }

    public string TProductNameByMaxPrice()
    {
        return _productDal.ProductNameByMaxPrice();
    }

    public string TProductNameByMinPrice()
    {
        return _productDal.ProductNameByMinPrice();
    }

    public decimal TProductPriceAvg(string productName)
    {
        if (string.IsNullOrWhiteSpace(productName))
        {
            throw new ArgumentException("Doğru Ürün Adı değil");
        }
        return _productDal.ProductPriceAvg(productName);
    }

    public void TUpdate(Product entity)
    {
        _productDal.Update(entity);
    }
}
