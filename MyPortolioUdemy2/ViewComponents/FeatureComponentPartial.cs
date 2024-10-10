using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy2.DAL.Context;

namespace MyPortolioUdemy2.ViewComponents
{
    public class FeatureComponentPartial : ViewComponent
    {

        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values= portfolioContext.Features.ToList();    
            return View(values);
        }
    }   
}
