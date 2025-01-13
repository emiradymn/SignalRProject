using SignalR.Business.Abstract;
using SignalR.DAL.Abstract;
using SignalR.Entity.Entities;

namespace SignalR.Business.Concrete;

public class MenuTableManager : IMenuTableService
{
    private readonly IMenuTableDal _menuTableDal;

    public MenuTableManager(IMenuTableDal menuTableDal)
    {
        _menuTableDal = menuTableDal;
    }

    public void TAdd(MenuTable entity)
    {
        _menuTableDal.Add(entity);
    }

    public void TDelete(MenuTable entity)
    {
        _menuTableDal.Delete(entity);
    }

    public MenuTable TGetById(int id)
    {
        return _menuTableDal.GetById(id);
    }

    public List<MenuTable> TGetListAll()
    {
        return _menuTableDal.GetListAll();
    }

    public int TMenuTableCount()
    {
        return _menuTableDal.MenuTableCount();
    }


    public void TUpdate(MenuTable entity)
    {
        _menuTableDal.Update(entity);
    }
}
