using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework;

public class EfCommentDal : GenericRepository<Comment>, ICommentDal
{
    public List<Comment> GetCommentListWithDestination()
    {
        using var context = new Context();
        return context.Comments!.Include(x => x.Destination).ToList();
    }
}