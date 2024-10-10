using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class SkillComponentPartial:ViewComponent
    {

public IViewComponentResult Invoke()
        {
            return View();  
        }


    }
}
