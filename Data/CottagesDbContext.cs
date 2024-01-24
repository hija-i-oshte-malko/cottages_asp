using cottages_asp.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cotagges_asp.Data;

public class CottagesDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
	public CottagesDbContext(DbContextOptions<CottagesDbContext> options)
	   : base(options) { }

	public DbSet<Building> Buildings => this.Set<Building>();
	public DbSet<Category> Categories => this.Set<Category>();
	public DbSet<Extra> Extras => this.Set<Extra>();
	public DbSet<Offer> Offers => this.Set<Offer>();
	public DbSet<Room> Rooms => this.Set<Room>();
	public DbSet<BuildingImages> BuildingImages => this.Set<BuildingImages>();
}

