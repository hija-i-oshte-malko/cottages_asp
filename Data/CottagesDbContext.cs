// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using cottages_asp.Models.Domein;
using Microsoft.EntityFrameworkCore;
using cottages_asp.Models.Entities;
using System.Collections.Generic;

namespace cotagges_asp.Data
{
	public class CottagesDbContext : DbContext
	{
		public CottagesDbContext(DbContextOptions<CottagesDbContext> options)
		 : base(options)
		{
		}
		public DbSet<Building> Buildings { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryHotel> Categoryhotels { get; set; }
		public DbSet<Extra> Extras { get; set; }
		public DbSet<Offer> Offers { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<RoomExtra> RoomExtras { get; set; }
		public DbSet<User> Users { get; set; }
	}
	}

}
