using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Mercury.Domain.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }

		[Display(Name ="Назва категорії")]
		public string Name { get; set; }
		public string Description { get; set; }

		public ICollection<Product> Products { get; set; }

		public Product Product { get; set; }
	}
}
