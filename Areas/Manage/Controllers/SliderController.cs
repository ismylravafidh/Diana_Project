using Microsoft.AspNetCore.Mvc;

namespace Diana_Project.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SliderController : Controller
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
        public IActionResult Create(Slider slider)
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Slider newSlider)
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
