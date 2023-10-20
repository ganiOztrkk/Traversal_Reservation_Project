using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ReservationManager : IReservationService
{
    private readonly IReservationDal _reservationDal;

    public ReservationManager(IReservationDal reservationDal)
    {
        _reservationDal = reservationDal;
    }

    public void Insert(Reservation entity)
    {
        _reservationDal.Insert(entity);
    }

    public void Delete(Reservation entity)
    {
        _reservationDal.Delete(entity);
    }

    public void Update(Reservation entity)
    {
        _reservationDal.Update(entity);
    }

    public Reservation? GetById(int id)
    {
        return _reservationDal.GetById(id);
    }

    public List<Reservation> GetList()
    {
        return _reservationDal.GetList();
    }
}