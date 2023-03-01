using Mercury.Domain.Entities;

namespace Mercury.Domain.Repositories.Abstract
{
	public interface IServiceItemsRepository
	{
		IQueryable<ServiceItem> GetServiceItems();
		ServiceItem GetServiceItemById(Guid id);
		void SaveServiceItem(ServiceItem entity);
		void DeliteServiceItem(Guid id);
	}
}
