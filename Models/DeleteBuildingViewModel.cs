// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace cottages_asp.Models;

public class DeleteBuildingViewModel
{
	public Guid BuildingId { get; set; }
	public string Location { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public int Review { get; set; }
}
}
