using Mercury.Domain.Entities;

namespace Mercury.Domain.Repositories.Abstract
{
	public interface IProductsRepository
	{
		IQueryable<Product> GetProducts();
		Product GetProductById(Guid id);
		void SaveProduct(Product entity);
		void DeliteProduct(Guid id);
	}
}
