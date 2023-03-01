using Mercury.Domain.Entities;
using Mercury.Domain.Repositories.Abstract;

namespace Mercury.Domain.Repositories.EntityFramework
{
	public class MockServiceItemsRepository : IServiceItemsRepository
	{
		private readonly AppDbContext context;
		public MockServiceItemsRepository(AppDbContext context)
		{
			this.context = context;
		}
		public void DeliteServiceItem(Guid id)
		{
			context.ServiceItems.Remove(new ServiceItem() { Id = id});
			context.SaveChanges();
		}

		public ServiceItem GetServiceItemById(Guid id)
		{
			return context.ServiceItems.FirstOrDefault(x => x.Id == id);
		}

		public IQueryable<ServiceItem> GetServiceItems()
		{
			return context.ServiceItems;
		}

		public void SaveServiceItem(ServiceItem entity)
		{
			if (entity.Id == default)
				context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
			else
				context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
		}
	}
}
