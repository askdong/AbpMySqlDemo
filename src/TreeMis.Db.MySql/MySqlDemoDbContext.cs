using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TreeMis.MultiTenancy;
using TreeMis.Authorization.Roles;
using TreeMis.Authorization.Users;


namespace TreeMis.Db.MySql
{
    public class MySqlDemoDbContext : AbpZeroDbContext<Tenant, Role, User, MySqlDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MySqlDemoDbContext(DbContextOptions<MySqlDemoDbContext> options)
            : base(options)
        {
        }
    
    }
}
