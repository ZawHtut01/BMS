using Microsoft.AspNetCore.Mvc;

namespace BMS.Web.Controllers
{
    public class DevelopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Develop()
        {
            return View();
        }
    }
}
