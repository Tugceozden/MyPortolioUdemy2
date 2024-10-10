using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class HeadComponentPartial: ViewComponent
    {

        public IViewComponentResult Invoke() 
        { 
            return View();
        } 



    }
}
