using Mercury.Domain;
using Mercury.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mercury.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TextFieldsController : Controller
	{
		private readonly DataManager dataManager;
		public TextFieldsController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}


		// GET: HomeController1/Edit/5
		public ActionResult Edit(string codeWord)
		{
			var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
			return View(entity);
		}

		
		[HttpPost]
		public ActionResult Edit(TextField model)
		{
			if(ModelState.IsValid)
			{
				dataManager.TextFields.SaveTextField(model);
				return RedirectToAction( "Index", "Home");
			}
			return View(model);
		}

		
		
	}
}
