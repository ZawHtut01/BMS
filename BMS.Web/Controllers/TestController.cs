using Microsoft.AspNetCore.Mvc;

namespace BMS.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
