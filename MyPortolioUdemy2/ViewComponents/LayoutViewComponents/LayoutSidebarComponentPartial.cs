using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents.LayoutViewComponents
{
	public class LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		} 
	}
}
