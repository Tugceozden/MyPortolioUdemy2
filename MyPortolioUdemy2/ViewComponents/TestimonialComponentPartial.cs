using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class TestimonialComponentPartial:ViewComponent
    {
public IViewComponentResult Invoke()
        {
            return View();  
        }




    }
}
