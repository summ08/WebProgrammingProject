using Microsoft.AspNetCore.Mvc;

namespace sukaHospital.Web.Areas.Hasta.Controllers
{
    [Area("Hasta")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
