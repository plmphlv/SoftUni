using ASPNetCoreMVCIntro.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreMVCIntro.Controllers
{
	public class ProductController : Controller
	{
		private readonly ILogger logger;

		private IEnumerable<ProductViewModel> products = new List<ProductViewModel>()
		{
			new ProductViewModel()
			{
				ProductId = 1,
				ProductName = "Cheese",
				ProductPrice = 7.00m,
			},
			new ProductViewModel()
			{
				ProductId = 2,
				ProductName = "Ham",
				ProductPrice = 5.50m,
			},
			new ProductViewModel()
			{
				ProductId = 3,
				ProductName = "Bread",
				ProductPrice = 1.50m,
			},
		};
		public ProductController(ILogger<ProductController> _logger)
		{
			logger = _logger;
		}

		public IActionResult All()
		{
			return View("Index", products);
		}
	}
}
