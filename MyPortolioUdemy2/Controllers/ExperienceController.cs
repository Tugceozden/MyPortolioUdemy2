using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy2.DAL.Context;

namespace MyPortolioUdemy2.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values=context.Experiences.ToList();    
            return View(values);
        }
    }
}
