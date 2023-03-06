using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mercury.Domain.Entities
{
	public class Product
	{
		[Required]
		public Guid Id { get; set; }

		[Display(Name = "Назва товару")]
		public  string? Title { get; set; }

		[Display(Name = "Ціна")]
		public decimal Price { get; set; }

		[Display(Name = "Короткий опис")]
		public  string? SubTitle { get; set; }

		/*[ForeignKey("CategoryId")]*/
		[InverseProperty("Products")]
		public int CategoryId { get; set; }



	}
}
