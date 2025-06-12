using Microsoft.AspNetCore.Mvc;

namespace MvcGiris.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
