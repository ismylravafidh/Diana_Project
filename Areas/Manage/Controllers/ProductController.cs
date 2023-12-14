namespace Diana_Project.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products =_context.Products.Where(p=>p.IsDeleted==false)
                .Include(p=>p.Images)
                .Include(p=>p.ProductColors).ThenInclude(p=>p.Color)
                .Include(p=>p.ProductMaterials).ThenInclude(p=>p.Material)
                .Include(p=>p.ProductSizes).ThenInclude(p=>p.Size).ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProductVm product)
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
