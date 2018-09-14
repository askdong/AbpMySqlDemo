using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ShopOrderProduct
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public decimal? Price { get; set; }
        public int? Count { get; set; }

        public ShopOrder Order { get; set; }
        public ShopProduct Product { get; set; }
    }
}
