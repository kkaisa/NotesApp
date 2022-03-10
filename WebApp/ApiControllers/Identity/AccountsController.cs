using Microsoft.AspNetCore.Mvc;

namespace WebApp.ApiControllers.Identity;

public class AccountsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}