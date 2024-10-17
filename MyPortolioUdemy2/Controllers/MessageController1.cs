using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy2.DAL.Context;

namespace MyPortolioUdemy2.Controllers
{
	public class MessageController1 : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();	
		public IActionResult Inbox()
		{
			var values=context.Messages.ToList();	
			return View(values);
		}
	}
}
