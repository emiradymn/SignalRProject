using System;
using SignalR.Entity.Entities;

namespace SignalR.Business.Abstract;

public interface ICategoryService : IGenericService<Category>
{
    public int TCategoryCount();
    public int TActiveCategoryCount();
    public int TPassiveCategoryCount();

}
