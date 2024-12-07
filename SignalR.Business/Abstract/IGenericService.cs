using System;

namespace SignalR.Business.Abstract;

public interface IGenericService<T> where T : class
{
    void TAdd(T entity);
    void TUpdate(T entity);
    void TDelete(T entity);
    T TGetById(int id);
    List<T> TGetListAll();
}
