$(document).ready(function () {
	$("[data-fancybox='gallery']").fancybox({
		loop: true,
		buttons: [
			"zoom",
			"slideShow",
			"fullScreen",
			"download",
			"thumbs",
			"close"
		],
	});
});
