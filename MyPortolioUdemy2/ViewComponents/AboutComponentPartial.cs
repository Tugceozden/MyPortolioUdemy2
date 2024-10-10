using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class AboutComponentPartial:ViewComponent
    {
public IViewComponentResult Invoke()
        {
            return View();  
        }


    }
}
