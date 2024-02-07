using Microsoft.EntityFrameworkCore;
using Prototype.Application.Domain.Entity;

namespace Prototype.Application.Domain.Repository
{
    public class PrototypeDBContext : DbContext
    {
        public PrototypeDBContext(DbContextOptions<PrototypeDBContext> options) : base(options)
        {
        }
        public DbSet<Product> Products => Set<Product>();
    }
}
