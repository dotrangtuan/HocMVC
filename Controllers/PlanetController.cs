using Microsoft.AspNetCore.Mvc;

public class PlanetController : Controller
{
    readonly PlanetService _planetService;
    public PlanetController(PlanetService planetService)
    {
        _planetService = planetService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [BindProperty(SupportsGet = true ,Name = "action")]
    public string? Name {get;set;}
    public IActionResult Mercury() {
        var kq = _planetService.Where(e => e.Name == Name).FirstOrDefault();
        return View("detail", kq);
    }

    public IActionResult Earth()
    {
        var kq = _planetService.Where(e => e.Name == Name).FirstOrDefault();
        return View("detail", kq);
    }

    public IActionResult Jupiter()
    {
        var kq = _planetService.Where(e => e.Name == Name).FirstOrDefault();
        return View("detail", kq);
    }

    public IActionResult Mars()
    {
        var kq = _planetService.Where(e => e.Name == Name).FirstOrDefault();
        return View("detail", kq);
    }

    public IActionResult Neptune()
    {
        var kq = _planetService.Where(e => e.Name == Name).FirstOrDefault();
        return View("detail", kq);
    }

    public IActionResult Saturn()
    {
        var kq = _planetService.Where(e => e.Name == Name).FirstOrDefault();
        return View("detail", kq);
    }

    public IActionResult Uranus()
    {
        var kq = _planetService.Where(e => e.Name == Name).FirstOrDefault();
        return View("detail", kq);
    }

    public IActionResult PlanetInfor(int? Id) {
        var kq = _planetService.Where(e => e.Id == Id).FirstOrDefault();
        return View("detail", kq); 
    }

}