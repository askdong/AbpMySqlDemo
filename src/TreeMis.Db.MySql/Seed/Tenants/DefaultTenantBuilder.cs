﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.MultiTenancy;

using TreeMis.MultiTenancy;
using TreeMis.Editions;
using TreeMis.Db.MySql.Models;

namespace TreeMis.Db.MySql.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly MySqlDemoDbContext _context;

        public DefaultTenantBuilder(MySqlDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            // Default tenant

            var shops = _context.Shop.ToList<Shop>();

            var list1= _context.Tenants.Where(u => u.IsActive == true).ToList();
            
            var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == AbpTenantBase.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new Tenant(AbpTenantBase.DefaultTenantName, AbpTenantBase.DefaultTenantName);

                var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}