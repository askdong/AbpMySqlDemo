using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ShopCustomer
    {
        public ShopCustomer()
        {
            ShopOrder = new HashSet<ShopOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Birthday { get; set; }
        public string Avatar { get; set; }
        public string Mobile { get; set; }
        public string Qq { get; set; }
        public string Wechat { get; set; }
        public string Address { get; set; }
        public int? Status { get; set; }
        public int? ShopId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public ICollection<ShopOrder> ShopOrder { get; set; }
    }
}
