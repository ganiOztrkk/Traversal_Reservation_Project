using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class NewsletterManager : INewsletterService
{
    private readonly INewsletterDal _newsletterDal;

    public NewsletterManager(INewsletterDal newsletterDal)
    {
        _newsletterDal = newsletterDal;
    }

    public void Insert(Newsletter entity)
    {
        _newsletterDal.Insert(entity);
    }

    public void Delete(Newsletter entity)
    {
        _newsletterDal.Delete(entity);
    }

    public void Update(Newsletter entity)
    {
        _newsletterDal.Update(entity);
    }

    public Newsletter? GetById(int id)
    {
        return _newsletterDal.GetById(id);
    }

    public List<Newsletter> GetList()
    {
        return _newsletterDal.GetList();
    }
}