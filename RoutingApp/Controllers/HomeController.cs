using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;
using System.Diagnostics;

namespace RoutingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        List<Product> productList = new List<Product>()
        {
            new Product()
            {
                ProductID = 1,
                ProductName="55 inch Televizyon",
                CategoryID=1,
                CategoryName = "Elektronik",
                Description = "Samsung 55 inch led tv"
            },
            new Product()
            {
                ProductID = 2,
                ProductName="Erkek KOt Pantalon",
                CategoryID=2,
                CategoryName = "Erkek Giyim",
                Description = "36 beden erkek mavi kot pantalon"
            },
            new Product()
            {
                ProductID = 3,
                ProductName="Mini F�r�n",
                CategoryID=3,
                CategoryName = "K���k ev aletleri",
                Description = "Beko micro dalga mini f�r�n"
            },
            new Product()
            {
                ProductID = 4,
                ProductName="Erkek Tshirt",
                CategoryID=2,
                CategoryName = "Erkek Giyim",
                Description = "V yaka erkek sar� tshirt"
            }
        };

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View(productList);
        }

        [Route("Privacy")]
        [Route("Home/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
