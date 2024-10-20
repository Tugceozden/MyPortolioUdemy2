using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy2.DAL.Context;  // Bu satır uzaktaki değişikliklerde eksikti, eklenmeli

namespace MyPortolioUdemy2.Controllers
{
	public class StatisticController1 : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();  // Yerel değişikliklerden bu satır korunmalı
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
			return View();  // Bu satır her iki değişiklikte de aynı, korunmalı 
		}
	}
}
