using SignalR.Entity.Entities;

namespace SignalR.DAL.Abstract;

public interface IMenuTableDal : IGenericDal<MenuTable>
{
    int MenuTableCount();
}
