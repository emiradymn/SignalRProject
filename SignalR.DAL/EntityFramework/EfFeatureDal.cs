using System;
using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
{
    public EfFeatureDal(SignalRContext context) : base(context)
    {
    }
}
