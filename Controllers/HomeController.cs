using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_Car.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
