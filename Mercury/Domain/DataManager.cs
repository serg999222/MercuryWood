using Mercury.Domain.Repositories.Abstract;

namespace Mercury.Domain
{
	public class DataManager
	{
		public ITextFieldRepository TextFields { get; set; }
		public IServiceItemsRepository ServiceItems { get; set; }
		public IProductsRepository Products { get; set; }
		public ICategoryRepository Categoryes { get; set; }

		public DataManager(ITextFieldRepository textFieldRepository, IServiceItemsRepository serviceItemsRepository,
			IProductsRepository productsRepository, ICategoryRepository categoryRepository)
		{
			TextFields = textFieldRepository;
			ServiceItems = serviceItemsRepository;
			Products = productsRepository;
			Categoryes = categoryRepository;
		}

	}
}
