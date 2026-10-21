using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _conext;
        public CategoryController(ApplicationDbContext context)
        {
            _conext = context;
        }
        public IActionResult Index()
        {
            var categories = _conext.Categories.ToList();
            return View("Index", categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public IActionResult CreatePOST(Category category)
        {
            _conext.Categories.Add(category);
            _conext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
