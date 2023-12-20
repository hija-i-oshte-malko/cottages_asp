using cotagges_asp.Data;
using cottages_asp.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace cottages_asp;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		string connStringName = "CottagesConnectionString";
		var connectionString = builder.Configuration.GetConnectionString(connStringName)
			?? throw new InvalidOperationException($"Connection string '{connStringName}' not found.");

		builder.Services.AddDbContext<CottagesDbContext>(options =>
			options.UseSqlServer(connectionString));

		builder.Services.AddDatabaseDeveloperPageExceptionFilter();

		builder.Services.AddDefaultIdentity<User>(options =>
		{
			options.SignIn.RequireConfirmedAccount = true;
		})
			.AddRoles<IdentityRole<Guid>>()
			.AddEntityFrameworkStores<CottagesDbContext>();

		builder.Services.AddControllersWithViews();
		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseMigrationsEndPoint();
		}
		else
		{
			app.UseExceptionHandler("/Home/Error");
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

		app.UseAuthentication();
		app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");
		app.MapRazorPages();

		app.Run();
	}
}
