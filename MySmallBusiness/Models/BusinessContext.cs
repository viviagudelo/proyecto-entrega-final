using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MySmallBusiness.Models
{
    public class BusinessContext : DbContext

    {
        public BusinessContext() : base("BusinessContext") { }
        
        public DbSet<Entrepreneurship> Entrepreneurships { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}