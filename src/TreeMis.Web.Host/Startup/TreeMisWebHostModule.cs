using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TreeMis.Configuration;
using TreeMis.Db.MySql;

namespace TreeMis.Web.Host.Startup
{
    [DependsOn(
       typeof(TreeMisWebCoreModule),
       typeof(DbMySqlModule))]
    public class TreeMisWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TreeMisWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TreeMisWebHostModule).GetAssembly());
        }
    }
}
