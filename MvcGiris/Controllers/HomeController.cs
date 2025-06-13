using Microsoft.AspNetCore.Mvc;
using MvcGiris.context;
using MvcGiris.entity;

namespace MvcGiris.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
            ClickContext clickContext = new ClickContext(); 

            var a= clickContext.Users.ToList();



            return View();
        }
       
    }
}
