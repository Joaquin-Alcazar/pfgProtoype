using Prototype.Application.Domain.Entity;

namespace Prototype.Business.Interfaces
{
	public interface IProductService
	{
		IList<Product> Products();
	}
}
