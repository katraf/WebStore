using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
            //return Content("First Controller action");
        }

        public IActionResult SecondAction(string id) => Content($"Action with value id:{id}");
    }
}
