using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TreeMis.Configuration;
using TreeMis.Db.MySql.Models;
using TreeMis.Web;

namespace TreeMis.Db.MySql
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MySqlDemoDbContextFactory : IDesignTimeDbContextFactory<MySqlDemoDbContext>
    {
        public MySqlDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MySqlDemoDbContext>();
            
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MySqlDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString("Default2"/**TreeMisConsts.ConnectionStringName**/));

            //todo 初始化 DbContent
            return new MySqlDemoDbContext(builder.Options);
            
        }
    }
}
