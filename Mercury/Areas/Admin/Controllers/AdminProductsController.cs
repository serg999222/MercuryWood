using Mercury.Domain.Entities;
using Mercury.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Mercury.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AdminProductsController : Controller
	{
		private readonly DataManager dataManager;
		private readonly IWebHostEnvironment hostEnvironment;
		public AdminProductsController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
		{
			this.dataManager = dataManager;
			this.hostEnvironment = hostEnvironment;
		}
		public IActionResult Index()
		{
			var products = dataManager.Products.GetProducts();
			return View(products);
		}

		public ActionResult Edit(Guid id)
		{
			var l = dataManager.Categoryes.GetCategoryes() as DbSet<Category>;
			var entity = id == default ? new Product() : dataManager.Products.GetProductById(id);
			/*	ViewData["CategoryId"] = new SelectList(dataManager.Categoryes.GetCategoryes(), "Id", "Id");*/
			ViewData["Name"] = new SelectList(dataManager.Categoryes.GetCategoryes() as DbSet<Category>, "Id", "Name");
			/*ViewData["Name"] = dataManager.Categoryes.GetCategoryes().Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString()});*/
			return View(entity);
		}

/*		public async Task<IActionResult> Create([Bind("ProductId,ProductName,ProductDescription,Price")] Product product)
		{
			var isHasProductName = _context.Product.Select(i => i.ProductName).ToList().Contains(product.ProductName);

			if (isHasProductName)
			{
				ModelState.AddModelError("ProductName", "Таке найменування товару вже є!");
			}
			if (ModelState.IsValid)
			{


				_context.Add(product);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(product);
		}*/

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Product model, IFormFile titleImageFile)
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
				ViewData["CustomerId"] = new SelectList(dataManager.Categoryes.GetCategoryes(), "Id", "Name");
				dataManager.Products.SaveProduct(model);
				return RedirectToAction("Index", "AdminProducts");
			}
			return View(model);
		}



		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(Guid id)
		{
			dataManager.Products.DeliteProduct(id);
			return RedirectToAction("Index", "AdminProducts");
		}
	}
	
}
