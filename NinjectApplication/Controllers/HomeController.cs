using System.Web.Mvc;
using NinjectApplication.Infrastructure;

namespace NinjectApplication.Controllers
{
	public class HomeController : Controller
	{
		private IMessagingService<App> _messagingService;

		public HomeController(IMessagingService<App> messagingService)
		{
			_messagingService = messagingService;
		}

		public ActionResult Index()
		{
			ViewBag.Message = "Welcome to ASP.NET MVC!";

			return View();
		}

		public ActionResult About()
		{
			return View();
		}
	}
}