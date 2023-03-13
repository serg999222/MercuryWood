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

		[Display(Name = "Титульна картинка")]
		public virtual string? TitleImagePath { get; set; }

		[Display(Name = "Ціна")]
		public decimal Price { get; set; }

		[Display(Name = "Короткий опис")]
		public  string? SubTitle { get; set; }

		/*[ForeignKey("CategoryId")]*/
		
		public int CategoryId { get; set; }

		public Category? category { get; }



	}
}
