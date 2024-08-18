using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;

namespace RoutingApp.Controllers
{
    public class ProductController : Controller
    {
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
                ProductName="Mini Fırın",
                CategoryID=3,
                CategoryName = "Küçük ev aletleri",
                Description = "Beko micro dalga mini fırın"
            },
            new Product()
            {
                ProductID = 4,
                ProductName="Erkek Tshirt",
                CategoryID=2,
                CategoryName = "Erkek Giyim",
                Description = "V yaka erkek sarı tshirt"
            }
        };
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Detail(int id)
        //{
        //    var product = productList.FirstOrDefault(x => x.ProductID == id);
        //    if (product == null) return BadRequest();

        //    return View(product);
        //}

        [Route("product-category-{categoryId}-{categoryname}-{pruductId}-{productname}")]
        [Route("Home/product-category-{categoryId}-{categoryname}-{pruductId}-{productname}")]
        public IActionResult Detail(int pruductId)
        {
            var product = productList.FirstOrDefault(x => x.ProductID == pruductId);
            if (product == null) return BadRequest();

            return View(product);
        }
    }
}
