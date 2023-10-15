using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class GuideManager : IGuideService
{
    private readonly IGuideDal _guideDal;

    public GuideManager(IGuideDal guideDal)
    {
        _guideDal = guideDal;
    }

    public void Insert(Guide entity)
    {
        _guideDal.Insert(entity);
    }

    public void Delete(Guide entity)
    {
        _guideDal.Delete(entity);
    }

    public void Update(Guide entity)
    {
        _guideDal.Update(entity);
    }

    public Guide? GetById(int id)
    {
        return _guideDal.GetById(id);
    }

    public List<Guide> GetList()
    {
        return _guideDal.GetList();
    }
}