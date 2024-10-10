using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
