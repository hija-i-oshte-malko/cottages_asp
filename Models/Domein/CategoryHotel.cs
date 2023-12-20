// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cottages_asp.Models.Domein;

public class CategoryHotel
{
	public CategoryHotel()
	{
		CategoryHotelId = Guid.NewGuid();
	}
	[Key]
	public Guid CategoryHotelId { get; set; }

	[ForeignKey("Building")]
	public Guid BuildingId { get; set; }
	public Building Building { get; set; }

	[ForeignKey("Category")]
	public Guid CategoryId { get; set; }
	public Category Category { get; set; }
}
