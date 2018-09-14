using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TreeMis.Authorization.Roles;
using TreeMis.Authorization.Users;
using TreeMis.MultiTenancy;

namespace TreeMis.EntityFrameworkCore
{
    public class TreeMisDbContext : AbpZeroDbContext<Tenant, Role, User, TreeMisDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TreeMisDbContext(DbContextOptions<TreeMisDbContext> options)
            : base(options)
        {
        }
    }
}
