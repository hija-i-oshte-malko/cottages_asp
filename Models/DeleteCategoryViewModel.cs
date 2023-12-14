// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace cottages_asp.Models;

public class DeleteCategoryViewModel
{
	public Guid CategoryId { get; set; }

	public string Name { get; set; }

	public string Icon { get; set; }
}
