using SignalR.Entity.Entities;

namespace SignalR.Business.Abstract;

public interface IMoneyCaseService : IGenericService<MoneyCase>
{
    decimal TTotalMoneyCaseAmount();
}
