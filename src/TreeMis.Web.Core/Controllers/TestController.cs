using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Dependency;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreeMis.Controllers;
using TreeMis.Db.MySql;
using TreeMis.Db.MySql.Models;

namespace TreeMis.Web.Host.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TestController : TreeMisControllerBase
    {   
        private readonly MySqlDemoDbContext _ctx;

        public TestController(MySqlDemoDbContext _dbContext) {

            _ctx = _dbContext;
        }
       
        //[AbpAuthorize("Administration.UserManagement.CreateUser")]
        [HttpGet]
        public List<ShopProduct> demo1() {
            
            var list= _ctx.ShopProduct.ToList();

            return list;
        }

        [HttpGet]
        public String demo2()
        {
            return "what a fuck";
        }
    }
}