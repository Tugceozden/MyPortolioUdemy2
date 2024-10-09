using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
