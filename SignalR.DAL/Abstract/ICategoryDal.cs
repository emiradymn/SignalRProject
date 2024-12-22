using System;
using SignalR.Entity.Entities;

namespace SignalR.DAL.Abstract;

public interface ICategoryDal : IGenericDal<Category>
{
    int CategoryCount();
    int ActiveCategoryCount();
    int PassiveCategoryCount();
}
