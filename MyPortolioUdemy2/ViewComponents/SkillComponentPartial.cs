using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy2.DAL.Context;

namespace MyPortolioUdemy2.ViewComponents
{
    public class SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
public IViewComponentResult Invoke()
        {
            var values=context.Skills.ToList();   
            return View(values);  
        }


    }
}
