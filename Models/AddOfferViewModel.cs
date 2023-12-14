// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using cottages_asp.Models.Entities;

namespace cottages_asp.Models;

public class AddOfferViewModel
{
	public Guid OfferId { get; set; }
	public Guid BuildingId { get; set; }
}
