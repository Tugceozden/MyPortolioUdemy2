using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
