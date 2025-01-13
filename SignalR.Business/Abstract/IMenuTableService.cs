using SignalR.Entity.Entities;

namespace SignalR.Business.Abstract;

public interface IMenuTableService : IGenericService<MenuTable>
{
    int TMenuTableCount();
}
