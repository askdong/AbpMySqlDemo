using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class Shop
    {
        public Shop()
        {
            ShopUser = new HashSet<ShopUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Site { get; set; }
        public string Remarks { get; set; }
        public string ShopType { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public ICollection<ShopUser> ShopUser { get; set; }
    }
}
