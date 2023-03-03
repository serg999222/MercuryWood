using Microsoft.AspNetCore.Mvc;

namespace Mercury.Controllers
{
	
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
