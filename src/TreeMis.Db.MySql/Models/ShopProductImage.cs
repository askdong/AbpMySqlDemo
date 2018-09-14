using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ShopProductImage
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Path { get; set; }
        public int? Index { get; set; }
        public DateTime? CreateDate { get; set; }

        public ShopProduct Product { get; set; }
    }
}
