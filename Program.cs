using cottages_asp.Data;
using Microsoft.EntityFrameworkCore;

namespace cottages_asp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();
			var connectionString = builder.Configuration.GetConnectionString("CottagesConnectionString") ?? throw new InvalidOperationException("Connection string 'CottagesConnectionString' not found.");
			builder.Services.AddDbContext<CottagesDbContext>(options =>
				options.UseSqlServer(connectionString));

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
}
