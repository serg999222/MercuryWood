using System.ComponentModel.DataAnnotations;

namespace Mercury.Domain.Entities
{
	public abstract class EntityBase
		
		
	{
		public EntityBase() => DateAddet = DateTime.UtcNow;

		[Required]
		public Guid Id { get; set; }

		[Display(Name="Назва(заголовок)")]
		public virtual string? Title { get; set; }

		[Display(Name = "Короткий опис")]
		public virtual string? SubTitle { get; set; }

		[Display(Name = "Повний опис")]
		public virtual string? Text { get; set; }

		[Display(Name = "Титульна картинка")]
		public virtual string? TitleImagePath { get; set; }

		[Display(Name = "SEO Metatag Title")]
		public virtual string? MetaTitle { get; set; }

		[Display(Name = "SEO Metatag Description")]
		public virtual string? MetaDescription { get; set; }

		[Display(Name = "SEO Metatag Keywords")]
		public virtual string? MetaKeywords { get; set; }

		[DataType(DataType.Time)]
		public DateTime DateAddet { get; set; }

	}
}
