using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TreeMis.Db.MySql
{
    public static class MySqlDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MySqlDemoDbContext> builder, string connectionString)
        {

            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MySqlDemoDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
