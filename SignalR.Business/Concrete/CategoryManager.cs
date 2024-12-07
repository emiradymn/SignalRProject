using System;
using SignalR.Business.Abstract;
using SignalR.DAL.Abstract;
using SignalR.Entity.Entities;

namespace SignalR.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void TAdd(Category entity)
    {
        _categoryDal.Add(entity);
    }

    public void TDelete(Category entity)
    {
        _categoryDal.Delete(entity);
    }

    public Category TGetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public List<Category> TGetListAll()
    {
        return _categoryDal.GetListAll();
    }

    public void TUpdate(Category entity)
    {
        _categoryDal.Update(entity);
    }
}
