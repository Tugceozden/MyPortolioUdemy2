using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class NavbarComponentPartial: ViewComponent
    {
        public IViewComponentResult   Invoke() 
        { 
            
            return View(); 
        }   


    }
}
