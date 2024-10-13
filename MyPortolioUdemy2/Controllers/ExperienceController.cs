using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
