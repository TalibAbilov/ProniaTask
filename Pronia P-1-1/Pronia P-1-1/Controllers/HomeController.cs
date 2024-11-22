using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_P_1_1.DAL;
using Pronia_P_1_1.Models;
using Pronia_P_1_1.ViewModels;

namespace Pronia_P_1_1.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext context;
        public HomeController(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public IActionResult Index()
        {
            List<Product> products = context.Products.Include(x=> x.ProductImages).ToList();
            List<Slider> sliders = context.Sliders.ToList();
            HomeVM vm = new HomeVM()
            {
                Sliders=sliders,
                Products=products,
            };
            return View(vm);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product=await context.Products.Include(x=>x.Category)
                .Include(x=>x.ProductImages)
                .Include(x=>x.TagProducts)
                .ThenInclude(tp=>tp.Tag)
                .FirstOrDefaultAsync(x => x.Id == id);
            return View(product);
            
        }
    }
}
