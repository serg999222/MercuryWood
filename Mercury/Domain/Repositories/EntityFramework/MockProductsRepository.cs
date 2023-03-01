using Mercury.Domain.Entities;
using Mercury.Domain.Repositories.Abstract;

namespace Mercury.Domain.Repositories.EntityFramework
{
	public class MockProductsRepository : IProductsRepository
	{
		private readonly AppDbContext context;
		public MockProductsRepository(AppDbContext context)
		{
			this.context = context;
		}
		public void DeliteProduct(Guid id)
		{
			context.Products.Remove(new Product() { Id = id});
			context.SaveChanges();
		}

		public Product GetProductById(Guid id)
		{
			return context.Products.FirstOrDefault(x => x.Id == id);
		}

		public IQueryable<Product> GetProducts()
		{
			return context.Products;
		}

		public void SaveProduct(Product entity)
		{
			if (entity.Id == default)
				context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
			else
				context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
		}
	}
}
