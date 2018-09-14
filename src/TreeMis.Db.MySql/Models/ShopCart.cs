using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ShopCart
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public decimal? Price { get; set; }
        public int? Count { get; set; }
        public int? ShopId { get; set; }
        public DateTime? CreateDate { get; set; }

        public ShopProduct Product { get; set; }
    }
}
