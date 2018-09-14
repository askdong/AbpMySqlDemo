using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ShopCategroy
    {
        public ShopCategroy()
        {
            ShopProduct = new HashSet<ShopProduct>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int? Status { get; set; }
        public int? ParentId { get; set; }
        public int? ShopId { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public ICollection<ShopProduct> ShopProduct { get; set; }
    }
}
