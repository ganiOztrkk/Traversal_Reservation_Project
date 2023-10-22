using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class CommentController : Controller
{
    private readonly ICommentService _commentService;

    public CommentController(ICommentService commentService)
    {
        _commentService = commentService;
    }

    // GET
    public IActionResult Index()
    {
        var comments = _commentService.GetCommentListWithDestination();
        return View(comments);
    }
    
    public IActionResult DeleteComment(int id)
    {
        var comment = _commentService.GetById(id);
        _commentService.Delete(comment!);
        return RedirectToAction("Index");
    }
}