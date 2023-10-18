using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Controllers;

public class CommentController : Controller
{
    private readonly ICommentService _commentService;

    public CommentController(ICommentService commentService)
    {
        _commentService = commentService;
    }

    [HttpGet]
    public PartialViewResult AddComment()
    {
        return PartialView();
    }
    
    [HttpPost]
    public IActionResult AddComment(Comment comment)
    {
        comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        comment.CommentStatus = true;
        _commentService.Insert(comment);
        return RedirectToAction("Index", "Destination");
    }
}