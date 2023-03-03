using Mercury.Domain;
using Mercury.Domain.Repositories.Abstract;
using Mercury.Domain.Repositories.EntityFramework;
using Mercury.Service;
using Microsoft.AspNetCore.Identity;
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
		builder.Services.AddTransient<DataManager>();

		//Підключаємо контекст БД
		builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

		builder.Services.AddIdentity<IdentityUser, IdentityRole>(opts =>
		{
			opts.User.RequireUniqueEmail = true;
			opts.Password.RequiredLength = 6;
			opts.Password.RequireNonAlphanumeric = false;
			opts.Password.RequireLowercase = false;
			opts.Password.RequireUppercase = false;
			opts.Password.RequireDigit = false;
		}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


		builder.Services.ConfigureApplicationCookie(options =>
		{
			options.Cookie.Name = "MercuryWoodAuth";
			options.Cookie.HttpOnly = true;
			options.LoginPath = "/account/login";
			options.AccessDeniedPath = "/account/accessdenied";
			options.SlidingExpiration = true;
		});

		//Налаштування політики авторизації для Admin area
		builder.Services.AddAuthorization(x =>
		{
			x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
		});

		builder.Services.AddControllersWithViews(x =>
		{
			x.Conventions.Add(new AdminAreaAutorisation("Admin", "AdminArea"));
		});

		
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

		app.UseCookiePolicy();
		app.UseAuthentication();
		app.UseAuthorization();

		app.MapControllerRoute(
			name: "admin",
			pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");

		app.Run();

	}
}