using SignalR.Entity.Entities;

namespace SignalR.DAL.Abstract;

public interface IMoneyCaseDal : IGenericDal<MoneyCase>
{
    decimal TotalMoneyCaseAmount();
}
