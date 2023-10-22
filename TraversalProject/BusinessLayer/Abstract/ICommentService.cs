using EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface ICommentService : IGenericService<Comment>
{
    public List<Comment> GetCommentListWithDestination();
}