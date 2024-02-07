using Prototype.Application.Domain.Entity;

namespace Prototype.Application.Domain.Repository
{
	public interface IRepository<T> where T : BaseEntity
	{
		public IQueryable<T> sqlTable { get; }
		public void Insert(T data);
		public void Delete(T data);
		public void Update(T data);

	}
}
