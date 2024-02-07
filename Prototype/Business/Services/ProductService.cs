using Prototype.Application.Domain.Entity;
using Prototype.Application.Domain.Repository;
using Prototype.Business.Interfaces;

namespace Prototype.Business.Services
{
	public class ProductService: IProductService
	{
		private IRepository<Product> products;

		public ProductService(IRepository<Product> _products)
		{
			products = _products;
		}

		public virtual IList<Product> Products( )
		{
			return products.sqlTable.ToList();
		}
	}
}
