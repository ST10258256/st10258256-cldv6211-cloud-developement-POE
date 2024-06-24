using KhumaloCraft.Models;
using KhumaloCraft.Models.Display;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;

namespace KhumaloCraft.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;

        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> ProductsView(string sterm = "", int categoryId = 0)
        {
            IEnumerable<Product> products = await _homeRepository.DisplayProducts(sterm, categoryId);
            IEnumerable<Category> categories = await _homeRepository.Categories();
            ProductDisplayModel productModel = new ProductDisplayModel
            {
                Products = products,
                Categories = categories,
                STerm = sterm,
                CategpryId = categoryId
            };
            return View(productModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
