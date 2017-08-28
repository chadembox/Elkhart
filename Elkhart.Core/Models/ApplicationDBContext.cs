using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Elkhart.Core.Models.Mapping;

namespace Elkhart.Core.Models
{
    public partial class ApplicationDBContext : DbContext
    {
        static ApplicationDBContext()
        {
            Database.SetInitializer<ApplicationDBContext>(null);
        }

        public ApplicationDBContext()
            : base("Name=ApplicationDBContext")
        {
        }

        public DbSet<ObjectName> ObjectNames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ObjectNameMap());
        }
    }
}
