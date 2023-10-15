using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class Feature2Manager : IFeature2Service
{
    private readonly IFeature2Dal _feature2Dal;

    public Feature2Manager(IFeature2Dal feature2Dal)
    {
        _feature2Dal = feature2Dal;
    }

    public void Insert(Feature2 entity)
    {
        _feature2Dal.Insert(entity);
    }

    public void Delete(Feature2 entity)
    {
        _feature2Dal.Delete(entity);
    }

    public void Update(Feature2 entity)
    {
        _feature2Dal.Update(entity);
    }

    public Feature2? GetById(int id)
    {
        return _feature2Dal.GetById(id);
    }

    public List<Feature2> GetList()
    {
        return _feature2Dal.GetList();
    }
}