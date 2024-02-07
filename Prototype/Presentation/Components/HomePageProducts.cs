using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Prototype.Business.Interfaces;
using Prototype.Business.Services;
using Prototype.Presentation.Models;
using System.Xml.Linq;

namespace Prototype.Presentation.Components
{
	public class HomePageProducts : ViewComponent
	{
		private readonly IProductService productService;

		public HomePageProducts(IProductService _productService)
		{
			productService = _productService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			//TODO: estudiar la forma asíncrona de realizan un proceso en un metodo (F:\11_PROJECT_LEARN_ASP\grandnode2\grandnode2-main\src\Web\Grand.Web\Features\Models\Products\GetProductOverview.cs)
			var model = new List<ProductModel>();

			foreach (var p in productService.Products())
			{
				model.Add(new ProductModel
				{
					Name = p.Name,
					Description = p.Description,
					Price = p.Price,
					PicturePath = p.PicturePath,
				});
			}
			return View(model);
		}


	}
}
