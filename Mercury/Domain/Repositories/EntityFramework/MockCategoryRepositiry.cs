using Mercury.Domain.Entities;
using Mercury.Domain.Repositories.Abstract;

namespace Mercury.Domain.Repositories.EntityFramework
{
	public class MockCategoryRepositiry : ICategoryRepository
	{
		private readonly AppDbContext context;
		public MockCategoryRepositiry(AppDbContext context)
		{
			this.context = context;
		}

		public void DeliteCategory(int id)
		{
			context.Categories.Remove(new Category() { CategoryId = id});
		}

		public Category GetCategoryById(int id)
		{
			return context.Categories.FirstOrDefault(x => x.CategoryId == id);
		}

		public IQueryable<Category> GetCategoryes()
		{
			return context.Categories;
		}

		public void SaveCategory(Category entity)
		{
			if (entity.CategoryId == default)
				context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
			else
				context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
		}
	}
}
