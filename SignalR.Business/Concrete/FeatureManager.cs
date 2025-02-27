using System;
using SignalR.Business.Abstract;
using SignalR.DAL.Abstract;
using SignalR.Entity.Entities;

namespace SignalR.Business.Concrete;

public class FeatureManager : IFeatureService
{
    private readonly IFeatureDal _featureDal;

    public FeatureManager(IFeatureDal featureDal)
    {
        _featureDal = featureDal;
    }

    public void TAdd(Feature entity)
    {
        _featureDal.Add(entity);
    }

    public void TDelete(Feature entity)
    {
        _featureDal.Delete(entity);
    }

    public Feature TGetById(int id)
    {
        return _featureDal.GetById(id);
    }

    public List<Feature> TGetListAll()
    {
        return _featureDal.GetListAll();
    }

    public void TUpdate(Feature entity)
    {
        _featureDal.Update(entity);
    }
}
