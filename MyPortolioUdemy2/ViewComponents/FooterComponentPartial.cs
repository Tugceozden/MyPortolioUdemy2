using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents
{
    public class FooterComponentPartial:ViewComponent
    {
        
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }    
        
        
                    
        
    }
}
