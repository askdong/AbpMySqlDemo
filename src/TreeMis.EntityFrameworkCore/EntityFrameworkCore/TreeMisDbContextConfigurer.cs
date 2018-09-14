using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TreeMis.EntityFrameworkCore
{
    public static class TreeMisDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TreeMisDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TreeMisDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
