using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class CommentManager : ICommentService
{
    private readonly ICommentDal _commentDal;

    public CommentManager(ICommentDal commentDal)
    {
        _commentDal = commentDal;
    }

    public void Insert(Comment entity)
    {
        _commentDal.Insert(entity);
    }

    public void Delete(Comment entity)
    {
        _commentDal.Delete(entity);
    }

    public void Update(Comment entity)
    {
        _commentDal.Update(entity);
    }

    public Comment? GetById(int id)
    {
        return _commentDal.GetById(id);
    }

    public List<Comment> GetList()
    {
        return _commentDal.GetList();
    }

    public List<Comment> GetCommentListWithDestination()
    {
        return _commentDal.GetCommentListWithDestination();
    }
}