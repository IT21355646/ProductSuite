using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Products/Details/{id}
        public IActionResult Details(int id)
        {
            // Pass the id to the view so the view's JS can fetch the product by id
            ViewBag.ProductId = id;
            return View();
        }

    }
}
