using Mercury.Domain;
using Mercury.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IO;

namespace Mercury.Controllers
{
	[Area("Admin")]
	public class ServiceItemController : Controller
	{
		private readonly DataManager dataManager;
		private readonly IWebHostEnvironment hostEnvironment;
		public ServiceItemController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
		{
			this.dataManager = dataManager;
			this.hostEnvironment = hostEnvironment;
		}


		public ActionResult Edit(Guid id)
		{
			var entity = id == default ? new ServiceItem() : dataManager.ServiceItems.GetServiceItemById(id);
			return View(entity);
		}



		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(ServiceItem model, IFormFile titleImageFile)
		{
			if (titleImageFile != null)
			{
				model.TitleImagePath = titleImageFile.FileName;
				using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
				{
					titleImageFile.CopyTo(stream);
				}
			}
			
			if (ModelState.IsValid)
			{

				dataManager.ServiceItems.SaveServiceItem(model);
				return RedirectToAction("Index", "Home");
			}
			return View(model);
		}



		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(Guid id)
		{
			dataManager.ServiceItems.DeliteServiceItem(id);
			return RedirectToAction("Index", "Home");
		}
	}
}
