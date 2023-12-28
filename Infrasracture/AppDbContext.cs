using Microsoft.EntityFrameworkCore;

namespace Infrasracture
{
    public class AppDbContext: DbContext
    {
        public DbSet<Test> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionStr = "server=localhost;uid=root;pwd=1234;database=taltest";

            optionsBuilder.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr));
        }
    }
}
