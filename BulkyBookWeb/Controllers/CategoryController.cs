using BulkyBookWeb.Data;
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
    }
}
