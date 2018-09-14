using System;
using System.Collections.Generic;

namespace TreeMis.Db.MySql.Models
{
    public partial class ShopProduct
    {
        public ShopProduct()
        {
            ShopCart = new HashSet<ShopCart>();
            ShopOrderProduct = new HashSet<ShopOrderProduct>();
            ShopProductImage = new HashSet<ShopProductImage>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Sn { get; set; }
        public string Code { get; set; }
        public string Factory { get; set; }
        public int? CateId { get; set; }
        public string Html { get; set; }
        public string HtmlText { get; set; }
        public decimal? PriceIn { get; set; }
        public decimal? PriceOut { get; set; }
        public int? StockNum { get; set; }
        public string ShopId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public ShopCategroy Cate { get; set; }
        public ICollection<ShopCart> ShopCart { get; set; }
        public ICollection<ShopOrderProduct> ShopOrderProduct { get; set; }
        public ICollection<ShopProductImage> ShopProductImage { get; set; }
    }
}
