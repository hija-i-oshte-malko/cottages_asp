using cotagges_asp.Data;
using Microsoft.EntityFrameworkCore;

namespace cottages_asp;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddControllersWithViews();
		builder.Services.AddDbContext<CottagesDbContext>(options =>
		options.UseSqlServer(builder.Configuration.GetConnectionString("CottagesConnectionString")));

		var app = builder.Build();

		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Home/Error");
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

		app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");

		app.Run();
	}
}
