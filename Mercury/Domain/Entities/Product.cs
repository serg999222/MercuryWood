using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mercury.Domain.Entities
{
	public class Product : EntityBase
	{
		[Display(Name = "Назва товару")]
		public override string Title { get; set; }

		[Display(Name = "Ціна")]
		public decimal Price { get; set; }
		
		public int CategoryId { get; set; }

		public Category Category { get; set; }


	}
}
