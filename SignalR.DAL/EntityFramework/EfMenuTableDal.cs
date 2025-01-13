using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
{
    public EfMenuTableDal(SignalRContext context) : base(context)
    {
    }

    public int MenuTableCount()
    {
        using var context = new SignalRContext();
        return context.MenuTables.Count();
    }
}
