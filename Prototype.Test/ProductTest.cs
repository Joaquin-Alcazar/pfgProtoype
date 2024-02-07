using Prototype.Application.Domain.Entity;
using Xunit;

namespace Prototype.Test
{
	public class ProductTest
	{

		[Fact]
		public void productIdGenerate()
		{
			Product p = new Product();

			Assert.NotNull(p.id);
			Assert.True(p.id.Length != 0);
		}
	}
}
