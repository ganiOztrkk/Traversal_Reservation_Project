using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Components.DestinationDetails;

public class _CommentList : ViewComponent
{
    private readonly ICommentService _commentService;

    public _CommentList(ICommentService commentService)
    {
        _commentService = commentService;
    }

    public IViewComponentResult Invoke(int id)
    {
        var comments = _commentService.GetList().Where(x => x.DestinationId == id && x.CommentStatus == true);
        return View(comments);
    }
}