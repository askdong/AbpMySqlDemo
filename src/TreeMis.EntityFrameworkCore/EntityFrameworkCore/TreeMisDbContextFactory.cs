using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TreeMis.Configuration;
using TreeMis.Web;

namespace TreeMis.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TreeMisDbContextFactory : IDesignTimeDbContextFactory<TreeMisDbContext>
    {
        public TreeMisDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TreeMisDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TreeMisDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TreeMisConsts.ConnectionStringName));

            return new TreeMisDbContext(builder.Options);
        }
    }
}
