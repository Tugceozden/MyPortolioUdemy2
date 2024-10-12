using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy2.DAL.Context;

namespace MyPortolioUdemy2.ViewComponents
{
    public class ExperienceComponentPartial:ViewComponent
    {

        MyPortfolioContext context=new MyPortfolioContext();
public IViewComponentResult Invoke()
        {
            var values=context.Experiences.ToList();    
            return View(values);  
        }


    }
}
