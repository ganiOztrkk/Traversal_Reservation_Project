using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalProject.Areas.Admin.Models;

namespace TraversalProject.Areas.Admin.Controllers;


[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class MailController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(RequestMailVM requestMailVm)
    {
        MimeMessage mimeMessage = new MimeMessage();
        
        MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "adminmail");
        mimeMessage.From.Add(mailboxAddressFrom);
        
        MailboxAddress mailboxAddressTo = new MailboxAddress("User", requestMailVm.ReceiverMail);
        mimeMessage.To.Add(mailboxAddressTo);

        mimeMessage.Subject = requestMailVm.Subject;
        SmtpClient client = new SmtpClient();
        client.Connect("smtp.gmail.com", 587, false);
        client.Authenticate("adminmail", "password");
        client.Send(mimeMessage);
        client.Disconnect(true);
        return View();
    }
}