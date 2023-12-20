// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cottages_asp.Models.Domein;

public class Category
{
	public Category()
	{
		CategoryId = Guid.NewGuid();
	}
	[Key]
	public Guid CategoryId { get; set; }

	[Required]
	public string Name { get; set; }
	[Required]
	public string Icon { get; set; }

	ICollection<CategoryHotel> CategoryHotels { get; set; }
}
