using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class SysAccount
    {
        public SysAccount()
        {
            ShopUser = new HashSet<ShopUser>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public ICollection<ShopUser> ShopUser { get; set; }
    }
}
