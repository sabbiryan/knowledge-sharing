using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace KS.EntityFrameworkCore
{
    public static class KSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<KSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<KSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
