using Mercury.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mercury.Domain
{
	public class AppDbContext : IdentityDbContext<IdentityUser>

	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ServiceItem> ServiceItems { get; set; }
		public DbSet<TextField> TextFields { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<IdentityRole>().HasData(new IdentityRole
			{
				Id = "948526e8-1620-4365-8a6b-ec37517d275e",
				Name = "admin",
				NormalizedName = "ADMIN"
			});

			builder.Entity<IdentityUser>().HasData(new IdentityUser
			{
				Id = "afea407f-e991-43f2-953a-1dabbf9bb024",
				UserName = "admin",
				NormalizedUserName = "ADMIN",
				Email = "myimail@gmail.com",
				NormalizedEmail = "MYIMAIL@GMAIL.COM",
				EmailConfirmed = true,
				PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
				SecurityStamp = string.Empty
			});

			builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
			{
				RoleId = "948526e8-1620-4365-8a6b-ec37517d275e",
				UserId = "afea407f-e991-43f2-953a-1dabbf9bb024"
			});

			builder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("69c7a66e-00ed-44ea-9ad3-3d8e5c0aecdb"),
				CodeWord = "PageIndex",
				Title = "Головна"
			});

			builder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("bc7322d6-c85a-4453-b3b3-9a1a27ccb3f2"),
				CodeWord = "ProductPage",
				Title = "Продукція"
			});

			builder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("3be10c44-818a-46ce-a08b-74780181e903"),
				CodeWord = "ServicePage",
				Title = "Додаткові послуги"
			});

			builder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("35830bab-542d-4e42-8277-65800bc26053"),
				CodeWord = "ContactsPage",
				Title = "Контакти"
			});



			builder.Entity<Category>().HasData(new Category
			{
				Id = 1,
				Name = "Столи",
				Description = "Столи"
			});

			builder.Entity<Product>().HasData(new Product
			{
				Id = new Guid("61d72b51-2294-4f0f-99e5-63bcbdf34991"),
				Title = "Стіл дубовий",
				Price = 17500,
				SubTitle = "Стіл Дубовий",
				CategoryId = 1

			});

		}
	}
}
