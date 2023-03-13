using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure
{
    public class EcommerceDataContext : DbContext
    {
        public EcommerceDataContext(DbContextOptions<EcommerceDataContext> options) : base(options)
        {

        }

        public DbSet<Brands> brands { get; set; }
    }
}
