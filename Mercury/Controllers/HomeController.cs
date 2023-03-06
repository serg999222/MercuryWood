using Mercury.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Mercury.Controllers
{
	
	public class HomeController : Controller
	{
		private readonly DataManager dataManager;

		public HomeController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}

		public IActionResult Index()
		{
			var textFieldData = dataManager.TextFields.GetTextFields();
			return View(textFieldData);
		}
	}
}
