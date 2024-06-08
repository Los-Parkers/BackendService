using catch_up_api.Shared.Infrastructure.Interfaces.Persistence.EPC.Configuration.Extensions;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;

namespace catch_up_api.Shared.Infrastructure.Interfaces.Persistence.EPC.Configuration
{
    public class AppDbContext(DbContextOptions options):DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.AddCreatedUpdatedInterceptor();
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            /* Entities to be created */

            builder.UseSnakeCaseNamingConvention();
        }
    }
}
