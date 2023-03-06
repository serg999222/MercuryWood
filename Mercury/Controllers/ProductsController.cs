using Mercury.Domain;
using Mercury.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mercury.Controllers
{
	
	public class ProductsController : Controller
	{
		private readonly DataManager dataManager;
		public ProductsController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}


		// GET: ProductsController
		public ActionResult Index()
		{
			var allproducts = dataManager.Products.GetProducts();
			return View(allproducts);
		}

		// GET: ProductsController/Details/5
		public ActionResult Details(Guid id)
		{
			var productById = dataManager.Products.GetProductById(id);
			return View(productById);
		}

		

		
		
	}
}
