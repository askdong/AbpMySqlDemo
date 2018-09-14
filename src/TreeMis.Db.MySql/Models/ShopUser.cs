using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ShopUser
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public string UserId { get; set; }
        public int? IsOwner { get; set; }
        public string ShopRole { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public Shop Shop { get; set; }
        public SysAccount User { get; set; }
    }
}
