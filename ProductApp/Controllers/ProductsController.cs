using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
