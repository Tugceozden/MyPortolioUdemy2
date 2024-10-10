using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class PortfolioComponentPartial:ViewComponent
    {
public IViewComponentResult Invoke()
        {
            return View();  
        }




    }
}
