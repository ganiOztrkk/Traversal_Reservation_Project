using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class DestinationManager : IDestinationService
{
    private readonly IDestinationDal _destinationDal;

    public DestinationManager(IDestinationDal destinationDal)
    {
        _destinationDal = destinationDal;
    }

    public void Insert(Destination entity)
    {
        _destinationDal.Insert(entity);
    }

    public void Delete(Destination entity)
    {
        _destinationDal.Delete(entity);
    }

    public void Update(Destination entity)
    {
        _destinationDal.Update(entity);
    }

    public Destination? GetById(int id)
    {
        return _destinationDal.GetById(id);
    }

    public List<Destination> GetList()
    {
        return _destinationDal.GetList();
    }

    public List<Destination> GetLast4Destinations()
    {
        return _destinationDal.GetLast4Destinations();
    }
}