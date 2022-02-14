using Microsoft.AspNetCore.Mvc;

namespace Insurance.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() 
        {
        }

        public IActionResult Index()
        {      
            return View();
        }

      
    }
}
