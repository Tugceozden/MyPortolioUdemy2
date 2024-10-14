using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy2.ViewComponents.LayoutViewComponents
{
	public class LayoutHeadComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}





	}
}
