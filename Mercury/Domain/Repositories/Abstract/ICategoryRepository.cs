using Mercury.Domain.Entities;

namespace Mercury.Domain.Repositories.Abstract
{
	public interface ICategoryRepository
	{
		IQueryable<Category> GetCategoryes();
		Category GetCategoryById(int id);
		void SaveCategory(Category entity);
		void DeliteCategory(int id);
	}
}
