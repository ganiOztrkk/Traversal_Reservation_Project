using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class About2Manager : IAbout2Service
{
    private readonly IAbout2Dal _about2Dal;

    public About2Manager(IAbout2Dal about2Dal)
    {
        _about2Dal = about2Dal;
    }

    public void Insert(About2 entity)
    {
        _about2Dal.Insert(entity);
    }

    public void Delete(About2 entity)
    {
        _about2Dal.Delete(entity);
    }

    public void Update(About2 entity)
    {
        _about2Dal.Update(entity);
    }

    public About2? GetById(int id)
    {
        return _about2Dal.GetById(id);
    }

    public List<About2> GetList()
    {
        return _about2Dal.GetList();
    }
}