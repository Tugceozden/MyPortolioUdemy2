using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy2.DAL.Entities;
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


        [HttpGet]
        public IActionResult CreateExperience() 
        {
        
        return View();
        
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience) 
        {
            context.Experiences.Add(experience); 
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
