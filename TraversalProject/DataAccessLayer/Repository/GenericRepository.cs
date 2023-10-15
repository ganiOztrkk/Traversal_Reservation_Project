using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository;

public class GenericRepository<T> : IGenericDal<T> where T : class, IEntity, new()
{
    public void Insert(T entity)
    {
        using Context context = new Context();
        context.Add(entity);
        context.SaveChanges();
    }

    public void Delete(T entity)
    {
        using Context context = new Context();
        context.Remove(entity);
        context.SaveChanges();

    }

    public void Update(T entity)
    {
        using Context context = new Context();
        context.Update(entity);
        context.SaveChanges();
    }

    public T? GetById(int id)
    {
        using Context context = new Context();
        return context.Set<T>().Find(id);
    }

    public List<T> GetList()
    {
        using Context context = new Context();
        return context.Set<T>().ToList();
    }
}