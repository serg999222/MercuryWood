using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Mercury.Domain.Entities
{
	public class ServiceItem : EntityBase
	{

		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Заповніть назву послуги")]
		[Display(Name = "Назва послуги")]
		public override string? Title { get; set; }

		[Display(Name = "Короткий опис послуги")]
		public override string? SubTitle { get; set; }

		[Display(Name = "Повний опис послуги")]
		public override string? Text { get; set; }


	}
}
