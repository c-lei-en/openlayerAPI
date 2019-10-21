using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace openlayerAPI.EntityFrameworkCore
{
    public static class openlayerAPIDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<openlayerAPIDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<openlayerAPIDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
