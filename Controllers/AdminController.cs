// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc;

namespace cottages_asp.Controllers;
public class AdminController : Controller
{
	[HttpGet]
	public IActionResult AdminBar()
	{
		return View();
	}
}
