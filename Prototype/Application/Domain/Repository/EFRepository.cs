using Prototype.Application.Domain.Entity;

namespace Prototype.Application.Domain.Repository
{
	
	public class EFRepository<T> : IRepository<T>  where T : BaseEntity
	{
		PrototypeDBContext context;

		//TODO: Comprobar porque la inyección de dependencia no utiliza La interfaz PrototypeDBContext 
		public EFRepository(PrototypeDBContext _context)
		{
			context = _context;
		}

		public IQueryable<T> sqlTable => (IQueryable<T>)context.Products;

		public void Delete(T data)
		{
			throw new NotImplementedException();
		}

		public void Insert(T data)
		{
			throw new NotImplementedException();
		}

		public void Update(T data)
		{
			throw new NotImplementedException();
		}
	}
}
