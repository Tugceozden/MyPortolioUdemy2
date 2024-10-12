using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy2.DAL.Context;

namespace MyPortolioUdemy2.ViewComponents
{
    public class AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext=new MyPortfolioContext();
public IViewComponentResult Invoke()
        {
              ViewBag.aboutTitle=portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault(); 
              ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault(); 
              ViewBag.aboutDetail=portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault(); 
            return View();  
        }


    }
}
