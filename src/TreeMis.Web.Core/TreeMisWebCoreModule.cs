using System;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.AspNetCore.SignalR;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.Configuration;
using TreeMis.Authentication.JwtBearer;
using TreeMis.Configuration;

using TreeMis.Db.MySql;
using Microsoft.EntityFrameworkCore;

using TreeMis.Web;
using Castle.MicroKernel.Registration;

namespace TreeMis
{
    [DependsOn(
         typeof(TreeMisApplicationModule),
         typeof(DbMySqlModule),
         typeof(AbpAspNetCoreModule)
        ,typeof(AbpAspNetCoreSignalRModule)

        ,typeof(DbMySqlModule)
     )]
    public class TreeMisWebCoreModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TreeMisWebCoreModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                TreeMisConsts.ConnectionStringName
            );

            // Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Modules.AbpAspNetCore()
                 .CreateControllersForAppServices(
                     typeof(TreeMisApplicationModule).GetAssembly()
                 );

            ConfigureTokenAuth();

            // sam@20180913 not work
            /**
            IocManager.Register<MySqlDemoDbContext>();
            var dbctx = IocManager.Resolve<MySqlDemoDbContext>();
            ***/

            var builder = new DbContextOptionsBuilder<MySqlDemoDbContext>();

            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MySqlDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString("Default"/**TreeMisConsts.ConnectionStringName**/));
            
            IocManager.IocContainer.Register(
               Component
                   .For<DbContextOptions<MySqlDemoDbContext>>()
                   .Instance(builder.Options)
                   .LifestyleSingleton()
                   );
            
        }

        private void ConfigureTokenAuth()
        {
            IocManager.Register<TokenAuthConfiguration>();
            var tokenAuthConfig = IocManager.Resolve<TokenAuthConfiguration>();

            tokenAuthConfig.SecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appConfiguration["Authentication:JwtBearer:SecurityKey"]));
            tokenAuthConfig.Issuer = _appConfiguration["Authentication:JwtBearer:Issuer"];
            tokenAuthConfig.Audience = _appConfiguration["Authentication:JwtBearer:Audience"];
            tokenAuthConfig.SigningCredentials = new SigningCredentials(tokenAuthConfig.SecurityKey, SecurityAlgorithms.HmacSha256);
            tokenAuthConfig.Expiration = TimeSpan.FromDays(1);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TreeMisWebCoreModule).GetAssembly());
        }
    }
}
