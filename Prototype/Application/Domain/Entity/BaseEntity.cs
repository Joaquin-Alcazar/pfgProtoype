namespace Prototype.Application.Domain.Entity
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            id = Guid.NewGuid().ToString();
        }

        public string id { get; set; }
    }
}
