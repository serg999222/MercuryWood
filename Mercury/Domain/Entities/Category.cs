using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mercury.Domain.Entities
{
	public class Category
	{
		public int Id { get; set; }

		[Display(Name ="Назва категорії")]
		public string? Name { get; set; }
		public string? Description { get; set; }

		
		public ICollection<Product>? Products { get; set; }
		
	}
}
