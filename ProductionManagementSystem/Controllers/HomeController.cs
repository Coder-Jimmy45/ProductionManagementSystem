using Microsoft.AspNetCore.Mvc;
using ProductionManagementSystem.Data;

namespace ProductionManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var materials = _context.Materials.ToList();

            ViewBag.TotalMaterials = materials.Count();
            ViewBag.LowStock = materials.Count(x => x.Quantity < x.MinStock);
            ViewBag.TotalQuantity = materials.Sum(x => x.Quantity);

            ViewBag.MaterialNames = materials.Select(x => x.MaterialName).ToList();
            ViewBag.MaterialQty = materials.Select(x => x.Quantity).ToList();

            return View();
        }
    }
}
