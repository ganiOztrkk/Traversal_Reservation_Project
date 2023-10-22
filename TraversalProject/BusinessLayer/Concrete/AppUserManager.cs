using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AppUserManager : IAppUserService
{
    private readonly IAppUserDal _appUserDal;

    public AppUserManager(IAppUserDal appUserDal)
    {
        _appUserDal = appUserDal;
    }

    public void Insert(AppUser entity)
    {
        _appUserDal.Insert(entity);
    }

    public void Delete(AppUser entity)
    {
        _appUserDal.Delete(entity);
    }

    public void Update(AppUser entity)
    {
        _appUserDal.Update(entity);
    }

    public AppUser? GetById(int id)
    {
        return _appUserDal.GetById(id);
    }

    public List<AppUser> GetList()
    {
        return _appUserDal.GetList();
    }
}