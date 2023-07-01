using Microsoft.EntityFrameworkCore;

namespace NetCoreElasticSearch.Context
{
    public class ElasticContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;database=Elastic;integrated security=true;");
        }
        public DbSet<Travel> Travels { get; set; }
    }
}