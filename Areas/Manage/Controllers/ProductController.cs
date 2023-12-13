using Microsoft.AspNetCore.Mvc;

namespace Diana_Project.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Product newProduct)
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
