using Microsoft.EntityFrameworkCore;
using cottages_asp.Models.Entities;

namespace cotagges_asp.Data;

public class CottagesDbContext : DbContext
{
	public CottagesDbContext(DbContextOptions<CottagesDbContext> options)
	   : base(options) { }

	public DbSet<Building> Buildings => this.Set<Building>();
	public DbSet<Category> Categories => this.Set<Category>();
	public DbSet<Extra> Extras => this.Set<Extra>();
	public DbSet<Offer> Offers => this.Set<Offer>();
	public DbSet<Room> Rooms => this.Set<Room>();
	public DbSet<User> Users => this.Set<User>();
}

