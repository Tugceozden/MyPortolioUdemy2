using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class StatisticComponentPartial:ViewComponent
    {

public IViewComponentResult Invoke()
        {
            return View();  
        }



    }
}
