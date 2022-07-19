using Microsoft.AspNetCore.Mvc;
using mvc.Data;
using mvc.Models;

namespace mvc.Controllers;

public class CategoryController : Controller
{
  private readonly ApplicationDbContext _db;

  public CategoryController(ApplicationDbContext db)
  {
    _db = db;
  }

  // GET
  public IActionResult Index()
  {
    IEnumerable<Category> objCategoryList = _db.Categories.ToList();
    return View(objCategoryList);
  }

  // GET
  public IActionResult Create()
  {
    return View();
  }

  // POST
  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult Create(Category obj)
  {
    _db.Categories.Add(obj);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }
}