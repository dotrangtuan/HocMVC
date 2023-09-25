using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Area("Database")]
[Route("/database-manage/[action]")]
public class DbManageController : Controller {

    private readonly AppDbContext _appDbContext;

    public DbManageController(AppDbContext appDbContext) {
        _appDbContext = appDbContext;
    }
    public IActionResult Index() => View();

    public IActionResult DeleteDb() => View();

    public async Task<IActionResult> Migrations() {
        
        // tạo cơ sở dữ liệu và cập nhật migrations
        await _appDbContext.Database.MigrateAsync();
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> AcceptDeleteDb() {
        await _appDbContext.Database.EnsureDeletedAsync();
        return RedirectToAction(nameof(Index));
    }
}