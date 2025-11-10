using Microsoft.AspNetCore.Mvc;

namespace BMS.Web.Controllers
{
    public class ProductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
