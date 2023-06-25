using BulkyWeb.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
    private readonly AppDbContext _db;
    public CategoryController(AppDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
	{
        var objCategoryList = _db.Categories.ToList();
		return View();
	}
}
