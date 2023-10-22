using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ContactMessageManager : IContactMessageService
{
    private readonly IContactMessageDal _contactMessageDal;

    public ContactMessageManager(IContactMessageDal contactMessageDal)
    {
        _contactMessageDal = contactMessageDal;
    }

    public void Insert(ContactMessage entity)
    {
        _contactMessageDal.Insert(entity);
    }

    public void Delete(ContactMessage entity)
    {
        _contactMessageDal.Delete(entity);
    }

    public void Update(ContactMessage entity)
    {
        _contactMessageDal.Update(entity);
    }

    public ContactMessage? GetById(int id)
    {
        return _contactMessageDal.GetById(id);
    }

    public List<ContactMessage> GetList()
    {
        return _contactMessageDal.GetList();
    }
}