using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents.LayoutViewComponents
{
	public class LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}




	}
}
