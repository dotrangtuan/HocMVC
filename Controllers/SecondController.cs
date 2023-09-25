using Microsoft.AspNetCore.Mvc;

public class SecondController : Controller
{
    public SecondController()
    {

    }

    public IActionResult Index()
    {
        return View("hihi");
    }
}