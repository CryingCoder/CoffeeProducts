using CoffeeShopProdList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopProdList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RegistrationForm()
        {
            return View();
        }

        public IActionResult Register(Registration r)
        {
            return View(r);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public class ProductsController : Controller
    {
        CoffeeShopContext db = new CoffeeShopContext();

        public IActionResult Index()
        {
            List<Product> Products = db.Products.ToList();
            foreach (Product p in Products)
            {

            }

            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}