using System.Web.Mvc;
using MvcTest.WebApplication.Models;
using MvcTest.WebApplication.Services;

namespace MvcTest.WebApplication.Controllers {
	public class HomeController : Controller {
		private readonly IClock clock;

		public HomeController(IClock clock) {
			this.clock = clock;
		}

		public ActionResult Index() {
			return View();
		}

		public ActionResult Welcome(string name) {
			var viewData = new WelcomeViewData() {
				Name = name,
				Date = clock.UtcNow.ToString("MMMM d, yyyy")
			};
			return (View(viewData));
		}
	}
}
