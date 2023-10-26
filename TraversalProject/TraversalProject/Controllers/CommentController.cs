using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Controllers;

public class CommentController : Controller
{
    private readonly ICommentService _commentService;
    private readonly UserManager<AppUser> _userManager;

    public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
    {
        _commentService = commentService;
        _userManager = userManager;
    }

    [HttpGet]
    public PartialViewResult AddComment()
    {
        return PartialView();
    }
    
    [HttpPost]
    public async Task<IActionResult> AddComment(Comment comment)
    {
        var user = await _userManager.FindByNameAsync(User.Identity!.Name!);
        var name = $"{user!.Name} {user.Surname}";
        comment.CommentUser = name;
        comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        comment.CommentStatus = true;
        _commentService.Insert(comment);
        return RedirectToAction("DestinationDetails", "Destination",new{id=comment.DestinationId});
    }
}