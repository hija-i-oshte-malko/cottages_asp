
var dropdowns = document.querySelectorAll(".admin-dropdown");


dropdowns.forEach(dropdown => {
	var dropdownMainItem = dropdown.querySelector(".admin-nav-dropdown")
	dropdownMainItem.addEventListener("click", e => {
		var dropdownItemsEl = dropdown.querySelector(".admin-nav-dropdown-items");

		dropdownItemsEl.classList.toggle("shown");
	});
});
