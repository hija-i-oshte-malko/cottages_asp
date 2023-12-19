// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cottages_asp.Models.Domein;

public class RoomExtra
{
	public RoomExtra()
	{
		RoomExtraId = Guid.NewGuid();
	}
	[Key]
	public Guid RoomExtraId { get; set; }

	[ForeignKey("Extra")]
	public Guid ExtraId { get; set; }
	public Extra Extra { get; set; }

	[ForeignKey("Room")]
	public Guid RoomId { get; set; }
	public Room Room { get; set; }
}
