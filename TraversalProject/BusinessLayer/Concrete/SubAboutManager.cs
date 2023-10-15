using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class SubAboutManager : ISubAboutService
{
    private readonly ISubAboutDal _subAboutDal;

    public SubAboutManager(ISubAboutDal subAboutDal)
    {
        _subAboutDal = subAboutDal;
    }

    public void Insert(SubAbout entity)
    {
        _subAboutDal.Insert(entity);
    }

    public void Delete(SubAbout entity)
    {
        _subAboutDal.Delete(entity);
    }

    public void Update(SubAbout entity)
    {
        _subAboutDal.Update(entity);
    }

    public SubAbout? GetById(int id)
    {
        return _subAboutDal.GetById(id);
    }

    public List<SubAbout> GetList()
    {
        return _subAboutDal.GetList();
    }
}