using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Mercury.Domain.Entities
{
	public class TextField : EntityBase
	{
		[System.ComponentModel.DataAnnotations.Required]
		public string CodeWord { get; set; }

		[Display(Name = "Назва(заголовок)")]
		public override string Title { get; set; } = "Інформаційна сторінка";

		[Display(Name = "Контент сторінки")]
		public override string Text { get; set; } = "Вміст заповнюється Адміністратором";
	}
}
