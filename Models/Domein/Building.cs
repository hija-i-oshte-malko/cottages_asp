// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.ComponentModel.DataAnnotations;

namespace cottages_asp.Models.Domein;

public class Building
{
	public Building()
	{
		BuildingId = Guid.NewGuid();
	}
	[Key]
	public Guid BuildingId { get; set; }

	[Required]
	public string Location { get; set; }

	[Required]

	public string Name { get; set; }

	[Required]
	public string Description { get; set; }

	[Required]
	public int Review { get; set; }

	public ICollection<Offer> Offers { get; set; }
}
