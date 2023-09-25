using App.Models;
using Microsoft.AspNetCore.Mvc;

public class FirstController : Controller
{

    private string rootPath;
    readonly ProductServices _productServices;

    public FirstController(IWebHostEnvironment env, ProductServices productServices)
    {
        rootPath = env.ContentRootPath;
        _productServices = productServices;
    }

    public IActionResult Product(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var product = _productServices.Products?.Where(p => p.Id == id).FirstOrDefault();
        return View("productView", product);
    }

    public IActionResult Flower()
    {
        string filePath = Path.Combine(rootPath, "Files", "hoagiay.jpg");
        var bytes = System.IO.File.ReadAllBytes(filePath);

        return File(bytes, "image/jpg");
    }

    public IActionResult Iphone()
    {
        return Json(
            new
            {
                name = "Iphone 15",
                price = 3000
            }
        );
    }

    public object HiHi()
    {

        return 9;
    }

    public IActionResult Index()
    {
        return View();
    }
}