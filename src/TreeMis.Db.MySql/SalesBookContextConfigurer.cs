using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using TreeMis.Db.MySql.Models;

namespace TreeMis.Db.MySql
{
    public static class SalesBookContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SalesBookContext> builder, string connectionString)
        {

            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SalesBookContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
