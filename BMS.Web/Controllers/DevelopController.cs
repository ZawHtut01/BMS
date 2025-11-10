using Microsoft.AspNetCore.Mvc;

namespace BMS.Web.Controllers
{
    public class DevelopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Master()

        {
            return View();
        }

        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
