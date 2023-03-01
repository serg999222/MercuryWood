using Mercury.Domain;
using Mercury.Domain.Repositories.Abstract;
using Mercury.Domain.Repositories.EntityFramework;
using Mercury.Service;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

internal class Program
{
	private static void Main(string[] args)
	{
		
		var builder = WebApplication.CreateBuilder(args);

		//Підключаємо конфіг із appsettings.json зв'язуємо appsettings.json з Config
		builder.Configuration.Bind("Project", new Config());

		//Підключаємо функціонал роботи з базами даних
		builder.Services.AddTransient<ICategoryRepository, MockCategoryRepositiry>();
		builder.Services.AddTransient<IProductsRepository, MockProductsRepository>();
		builder.Services.AddTransient<IServiceItemsRepository, MockServiceItemsRepository>();
		builder.Services.AddTransient<ITextFieldRepository, MockTextFieldRepository>();

		//Підключаємо контекст БД
		builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer)

		builder.Services.AddControllersWithViews();

		
		var app = builder.Build();


		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Home/Error");

			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

/*		app.UseAuthorization();*/

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");

		app.Run();

	}
}