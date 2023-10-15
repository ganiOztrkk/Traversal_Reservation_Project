using EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface IGenericService<T> where T: class, IEntity, new()
{
    public void Insert(T entity);
    public void Delete(T entity);
    public void Update(T entity);
    public T? GetById(int id);
    public List<T> GetList();
}