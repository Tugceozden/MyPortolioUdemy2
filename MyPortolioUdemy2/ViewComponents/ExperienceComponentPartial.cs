using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class ExperienceComponentPartial:ViewComponent
    {
public IViewComponentResult Invoke()
        {
            return View();  
        }


    }
}
