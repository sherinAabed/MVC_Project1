using Microsoft.AspNetCore.Mvc;

namespace kASHOP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

            //return View(); =>      return View("Index");
            //Action name same as View name > so we can leave it empty
            //return Content("this is Home for Admin "); => if we want  RETURN STRING : USE Content
        }
    }
}
