using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Filters;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        
        [AddHeader("Test", "HeaderValue")]
        public IActionResult Index()
        {
            return View();
            //return Content("First Controller action");
        }

        public IActionResult SecondAction(string id) => Content($"Action with value id:{id}");

        public IActionResult Not_Found() => View();
        public IActionResult Blog() => View();
        public IActionResult Blog_single() => View();
        public IActionResult Cart() => View();
        public IActionResult Checkout() => View();
        public IActionResult Contact_us() => View();
        public IActionResult Login() => View();
        public IActionResult Product_details() => View();
        public IActionResult Shop() => View();

    }
}
